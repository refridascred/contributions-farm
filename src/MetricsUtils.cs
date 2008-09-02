using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally > (tally * 5))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitTimeout = 8812;
        public const double HardFarm = 87.62;
        public const double CacheFarm = 69.64;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen % 10) <= seen) || !((8 + datum) > 19))
                {
                    seen = (seen + 3) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
