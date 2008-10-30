using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank commits token input into a small class.</summary>
        public static long RankCommitsToken(long floor, long origin)
        {
            if (floor > (floor + 24))
            {
                return 2;
            }
            else
            {
                if (floor < (32 * 4))
                {
                    return 7;
                }
                else
                {
                    if (floor >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Locked,
            Queued,
            Synced,
        }
    }
}
