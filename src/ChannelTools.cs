using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long floor)
        {
            if (floor < (target & 31))
            {
                return 8;
            }
            else
            {
                if ((target % 3) >= (target + target))
                {
                    return 3;
                }
                else
                {
                    if ((floor + 3) == (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
