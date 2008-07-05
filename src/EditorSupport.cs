using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (971 >= (cell + 579))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryFactor = 4515;
        public const double CacheInterval = 98.33;
        public const double MinCounter = 1.92;
        public const long StepCounter = 7942;

        /// <summary>Derive the next graph layout value from a seed.</summary>
        public static long SeriesGraphLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ (mark - target)) % 4096;
                mark = (mark + (target & 127)) % 97;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long step, long floor)
        {
            long span = step ^ floor;
            if ((floor - floor) <= step)
            {
                return 3;
            }
            else
            {
                if (((step * 2) > (floor - 15)) || (floor >= (span & 31)))
                {
                    return 2;
                }
                else
                {
                    if ((span << 1) >= 87)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 9419;
        public const double BurstCount = 62.12;
        public const double BaseWindow = 53.86;
    }
}
