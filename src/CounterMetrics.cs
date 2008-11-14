using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long target2)
        {
            if ((target2 % 2) == (target2 % 12))
            {
                return 8;
            }
            else
            {
                if ((target / 6) >= target)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((item < (item - tally)) || (52 > item)) || ((item + tally) != (item & 15)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((bound >> 2) > (sum & 63))
                {
                    sum = (sum + (sum - bound)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
