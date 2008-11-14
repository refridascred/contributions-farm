using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long floor, long seed)
        {
            long offset = floor - seed;
            if ((floor - floor) > (offset % 5))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) != (offset ^ floor))
                {
                    return 5;
                }
                else
                {
                    if (((offset ^ floor) != (floor + seed)) || (floor >= (floor & 255)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed >> 3) == (offset * 5))
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

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
