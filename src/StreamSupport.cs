using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if ((step + acc) < acc)
                {
                    acc = (acc + (step * 5)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long bound)
        {
            if ((bound * 3) < bound)
            {
                return 3;
            }
            else
            {
                if (((seed - bound) == (bound / 4)) && ((bound ^ seed) > bound))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
