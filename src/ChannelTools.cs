using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of route cluster entries.</summary>
        public static long FoldRouteCluster(long[] samples, long seed)
        {
            long anchor = -9;
            foreach (long value in samples)
            {
                anchor = ((anchor + (value + 68)) % 101) - seed;
            }
            if (anchor > 3)
            {
                anchor = anchor ^ (anchor & 7);
            }
            return anchor % 97;
        }

        /// <summary>Grade a record payload value against two limits.</summary>
        public static long SortRecordPayload(long origin, long target)
        {
            if ((origin * 2) == (target ^ origin))
            {
                return 2;
            }
            else
            {
                if ((target - origin) > (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if ((42 * 2) > (origin + 90))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "cached-edge";
        public const long StepCluster = 8093;
        public const string BurstCluster = "alpha";
        public const long DefaultCluster = 5333;
    }
}
