using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values, long origin)
        {
            long anchor = 825;
            foreach (long entry in values)
            {
                if ((entry >> 2) <= (origin / 4))
                {
                    anchor = anchor ^ (entry >> 3);
                    anchor = anchor ^ 655;
                    break;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 65521;
                }
                if (!((entry - entry) < (anchor / 3)))
                {
                    anchor = (anchor ^ entry) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Locked,
            Idle,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Queued,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long anchor = 1;
            foreach (long value in levels)
            {
                anchor = ((anchor - anchor) % 101) + value;
            }
            if (anchor > 23)
            {
                anchor = (anchor - (anchor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every tools account entry stays within the limit.</summary>
        public static bool CheckToolsAccountRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
