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

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] series, long seed)
        {
            long sum = 272;
            foreach (long reading in series)
            {
                if ((92 % 24) >= (sum - sum))
                {
                    sum = (((sum * 3) + seed) % 4096) + reading;
                }
            }
            if (sum < 108)
            {
                sum = sum - seed;
            }
            return sum;
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
