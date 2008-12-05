using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long floor)
        {
            if (((-5) << 3) >= seed)
            {
                return 8;
            }
            else
            {
                if ((seed * 5) <= floor)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many filter batches samples are out of range.</summary>
        public static long CountFilterBatchesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading & 15) < reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
