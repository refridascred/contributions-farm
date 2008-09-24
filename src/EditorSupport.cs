using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] values, long floor)
        {
            long mix = 494;
            foreach (long item in values)
            {
                if ((mix + mix) > (mix * 4))
                {
                    mix = (mix ^ (floor ^ floor)) % 101;
                }
                else
                {
                    mix = mix + (mix ^ item);
                }
                if (((item & 255) != (1 << 3)) && (floor < mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Iterate the report channel series from a seed.</summary>
        public static long StepReportChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseBudget = 6361;
        public const long HardRatio = 4940;
        public const long BurstInterval = 4019;
        public const double BatchSize = 40.55;
        public const long BaseSchema = 9230;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
