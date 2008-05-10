using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long seed, long seed2)
        {
            long delta = seed - seed2;
            if ((5.0 / 4.0) >= (10.0 + 5.58))
            {
                return 4;
            }
            else
            {
                if (!(delta <= (1 + seed2)))
                {
                    return 0;
                }
                else
                {
                    if (((seed + seed2) >= (delta - 2)) && (seed2 > (seed2 & 15)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.0 - 2.8) > (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
