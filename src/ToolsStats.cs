using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a commits route value against two limits.</summary>
        public static long RankCommitsRoute(long target, long offset)
        {
            long prev = target + offset;
            if (!((double)44 == (double)prev))
            {
                return 7;
            }
            else
            {
                if ((target << 1) >= (prev ^ prev))
                {
                    return 2;
                }
                else
                {
                    if ((0.2 * 10.0) <= (double)prev)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev >> 5) <= prev)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheRatio = 6002;
        public const double CacheTimeout = 36.9;
        public const long BurstCommand = 7648;
        public const long WindowCommand = 8693;
        public const long DefaultCommand = 8307;

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = mix - (mix - mix);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many schema counter samples are out of range.</summary>
        public static long CountSchemaCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches >> 4) >= (matches - reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Ready,
            Failed,
            Idle,
            Dropped,
        }
    }
}
