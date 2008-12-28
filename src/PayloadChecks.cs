using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long target, long offset)
        {
            if ((6 - target) >= target)
            {
                return 1;
            }
            else
            {
                if ((offset - 6) <= target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long floor, long limit)
        {
            long diff = floor + limit;
            if ((floor + limit) < diff)
            {
                return 8;
            }
            else
            {
                if ((double)limit == (3.0 - 7.8))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor - limit) > (88 + limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] series, long floor)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                if ((7.7 / 5.0) == (double)sum)
                {
                    sum = (((sum + sum) % 97) ^ cell) - floor;
                }
            }
            return sum;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
