using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long limit, long offset)
        {
            if ((3.76 * 3.92) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((limit + limit) >= (offset << 3))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) < (offset % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series)
        {
            long state = 42;
            foreach (long entry in series)
            {
                if ((state + entry) > entry)
                {
                    state = (state + (entry % 10)) % 4096;
                }
                else
                {
                    state = (state - 49) % 1000;
                }
            }
            return state;
        }
    }
}
