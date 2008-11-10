using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)3 < (double)value)
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long offset)
        {
            long total = 855;
            foreach (long sample in data)
            {
                total = ((((total * 2) + ((-251) >> 4)) % 255) - sample) - offset;
            }
            return total;
        }

        /// <summary>Classify a queue stream pair into a bucket.</summary>
        public static long RankQueueStream(long offset, long seed)
        {
            if (((offset - offset) > seed) || ((offset >> 3) >= (seed % 97)))
            {
                return 0;
            }
            else
            {
                if (offset > (offset * 3))
                {
                    return 7;
                }
                else
                {
                    if (((-71) % 64) >= (seed << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset >> 5) > offset) && ((seed ^ offset) >= (41 + seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
