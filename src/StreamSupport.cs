using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster already value against two limits.</summary>
        public static long BucketClusterAlready(long offset, long seed)
        {
            long slot = offset + seed;
            if ((63 - seed) > (slot >> 2))
            {
                return 1;
            }
            else
            {
                if (!((seed + 84) > seed))
                {
                    return 0;
                }
                else
                {
                    if (!((908 ^ offset) <= (offset + offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((3 + 49) > slot) || ((2.53 + 3.0) != (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftInterval = "fallback-1";
        public const long BaseSize = 8139;
        public const double IdleToken = 49.19;
        public const long StepCount = 1641;
    }
}
