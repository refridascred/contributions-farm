using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "latest-v2";
        public const long CacheScore = 4922;
        public const string HardMetrics = "fallback-v2";
        public const string WindowMetrics = "fallback-1";
        public const string DefaultMetrics = "standard";

        /// <summary>Iterate the batch checks series from a seed.</summary>
        public static long SeriesBatchChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                long slot = (floor - mark) - ((long)i * 3);
                if ((double)slot <= (0.8 / 6.0))
                {
                    slot = ((slot * 4) + ((-6) >> 1)) % 65521;
                    slot = ((slot * 4) + mark) % 4096;
                }
                else
                {
                    mark = ((mark * 4) + (slot ^ slot)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate checks contributi readings against a bound.</summary>
        public static bool ValidateChecksContributiLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Token { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Stale,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
