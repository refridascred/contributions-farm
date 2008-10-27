using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double gain = (floor - ratio) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (ratio / 4.0)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long offset)
        {
            long bound = seed ^ offset;
            if (0.19 < (double)offset)
            {
                return 5;
            }
            else
            {
                if (!((double)offset >= (0.74 + 11.0)))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (2.1 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 16) > (1 * 2))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Stale,
            Paused,
        }
    }
}
