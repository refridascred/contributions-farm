using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultWidth = 9957;
        public const long MinFormat = 3692;
        public const string LimitFormat = "latest-v2";

        /// <summary>Classify a counter graph pair into a bucket.</summary>
        public static long RankCounterGraph(long step, long floor)
        {
            long bound = step - floor;
            if ((double)step >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound >= (bound * 3)) || (bound < (bound + step)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
