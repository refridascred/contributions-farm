using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long total = 99;
            foreach (long value in readings)
            {
                total = total ^ value;
                if ((total * 2) > (value % 3))
                {
                    total = total - (value >> 5);
                }
            }
            return total;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Retry,
            New,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Idle,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long bound, long target)
        {
            long lane = bound ^ target;
            if ((lane % 2) >= (22 / 2))
            {
                return 2;
            }
            else
            {
                if ((double)target <= 10.0)
                {
                    return 7;
                }
                else
                {
                    if (((target << 2) == (target & 63)) || ((4.8 * 1.1) == (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)lane != (double)bound) && ((lane & 31) > (lane / 8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
