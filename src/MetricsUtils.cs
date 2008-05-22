using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Stale,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((5 + 22) > (bound2 << 3))
            {
                return 5;
            }
            else
            {
                if ((3.0 - 8.3) == (double)bound2)
                {
                    return 3;
                }
                else
                {
                    if ((4.0 <= (double)gap) && ((bound >> 1) == (194 * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + 79) >= (gap % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings)
        {
            long sum = 15;
            foreach (long cell in readings)
            {
                if (cell < 40)
                {
                    sum = (sum << 3) ^ (cell + cell);
                }
            }
            return sum % 97;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
