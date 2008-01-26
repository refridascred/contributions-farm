using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long limit)
        {
            long delta = floor + limit;
            if (((floor >> 3) > 2) || (2 <= (delta * 3)))
            {
                return 6;
            }
            else
            {
                if (((limit + limit) == (floor * 3)) && ((delta * 2) < (floor << 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Synced,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (5.1 >= (double)offset)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long floor2)
        {
            if (((836 + 2) > (floor2 / 5)) && ((floor2 % 97) < (floor * 2)))
            {
                return 5;
            }
            else
            {
                if ((floor2 >> 2) == (floor * 2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] readings)
        {
            long total = 72;
            foreach (long entry in readings)
            {
                if (((9.48 / 2.0) != (double)entry) && ((entry << 2) >= (entry ^ entry)))
                {
                    total = (total ^ entry) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (total + total)) % 65521;
                }
                if ((entry - total) >= (total - entry))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
