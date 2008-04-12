using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long step)
        {
            if ((step << 2) >= (target >> 4))
            {
                return 2;
            }
            else
            {
                if ((target * 2) <= step)
                {
                    return 1;
                }
                else
                {
                    if ((target + target) <= target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long floor)
        {
            long anchor = 237;
            foreach (long cell in levels)
            {
                if ((anchor - anchor) > (56 / 7))
                {
                    break;
                }
                if (!(cell >= (floor & 1)))
                {
                    anchor = anchor ^ (cell - floor);
                }
                else
                {
                    anchor = (anchor << 2) ^ cell;
                }
            }
            if (anchor > (-935))
            {
                anchor = ((anchor * 3) + (floor ^ floor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryScore = 25.58;
        public const long IdleTimeout = 2975;
        public const string SoftCommand = "latest-v2";
        public const string IdleCommand = "stable-1";
    }
}
