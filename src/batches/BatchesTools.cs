using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long floor, long target)
        {
            if (floor > target)
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (20.0 * 4.49))
                {
                    return 1;
                }
                else
                {
                    if ((double)target <= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)floor < (double)target) || ((double)floor > 12.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading < (seed ^ 81))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
