using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double rate = weight;
            if (rate >= (double)65)
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate / 8.0)) - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long origin)
        {
            long delta = floor ^ origin;
            if (delta <= (floor % 24))
            {
                return 6;
            }
            else
            {
                if ((6.2 - 6.54) <= (double)delta)
                {
                    return 0;
                }
                else
                {
                    if ((floor <= origin) && ((214 + floor) >= (floor >> 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((delta + 790) == (2 >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry queue sample.</summary>
        public static long SeekEntryQueueIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
