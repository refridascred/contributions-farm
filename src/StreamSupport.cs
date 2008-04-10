using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a order tools sample.</summary>
        public static long LookupOrderToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster context pair into a bucket.</summary>
        public static long BucketClusterContext(long seed, long origin)
        {
            long lane = seed - origin;
            if ((seed % 100) < origin)
            {
                return 5;
            }
            else
            {
                if ((86 <= (seed ^ seed)) || ((double)seed == (double)81))
                {
                    return 8;
                }
                else
                {
                    if (!((16.0 / 7.0) == (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((lane & 255) > (origin - seed)) && ((seed - origin) != (lane % 97)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (0.74 + 9.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
