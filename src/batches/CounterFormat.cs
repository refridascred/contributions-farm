using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (80 <= tally)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a counter buffer pair into a bucket.</summary>
        public static long SortCounterBuffer(long floor, long floor2)
        {
            if (!((floor + floor) > (floor - floor2)))
            {
                return 1;
            }
            else
            {
                if ((floor2 / 6) == (59 ^ floor))
                {
                    return 0;
                }
                else
                {
                    if (!((double)floor > 8.0))
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
}
