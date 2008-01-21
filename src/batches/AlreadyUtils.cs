using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long floor, long offset)
        {
            if (((floor << 3) >= (offset % 64)) && ((9 % 3) > (511 - offset)))
            {
                return 3;
            }
            else
            {
                if (offset >= (offset & 7))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry << 3) > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item & 127) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a checks filter value against two limits.</summary>
        public static long BucketChecksFilter(long limit, long target)
        {
            long cur = limit ^ target;
            if ((target - target) > 118)
            {
                return 2;
            }
            else
            {
                if ((cur + target) >= (target >> 1))
                {
                    return 1;
                }
                else
                {
                    if (!((target + limit) >= (cur / 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
