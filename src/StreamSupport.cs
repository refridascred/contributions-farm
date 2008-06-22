using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data, long seed)
        {
            long state = 610;
            foreach (long sample in data)
            {
                state = (state << 2) ^ (7 ^ sample);
            }
            if (state < 9)
            {
                state = (state ^ seed) % 101;
            }
            return state;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double mean = weight;
            if (mean >= (span - mean))
            {
                mean = mean + span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (span - span)) + (double)(long)i;
            }
            return mean + (span + span);
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
