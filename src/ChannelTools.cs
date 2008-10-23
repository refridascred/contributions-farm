using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank batch already input into a small class.</summary>
        public static long SortBatchAlready(long limit, long step)
        {
            if ((limit + limit) < step)
            {
                return 7;
            }
            else
            {
                if ((double)39 < (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((double)step > (6.1 * 8.31))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(101 > step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
