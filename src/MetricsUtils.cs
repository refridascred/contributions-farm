using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long offset)
        {
            long gap = seed + offset;
            if ((gap + offset) == (offset - 704))
            {
                return 3;
            }
            else
            {
                if ((offset ^ gap) != (gap << 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
