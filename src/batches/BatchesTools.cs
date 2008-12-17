using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data, long offset)
        {
            long mix = 59;
            foreach (long cell in data)
            {
                if ((mix - offset) > (382 - cell))
                {
                    mix = (mix ^ (offset ^ cell)) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (offset & 15)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)offset != (3.0 / 5.0))
                {
                    state = ((state << 2) ^ (offset - state)) % 97;
                    state = state + state;
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen - seen) >= (seen >> 1))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
