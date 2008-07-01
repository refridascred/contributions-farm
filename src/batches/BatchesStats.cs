using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples, long limit)
        {
            long acc = -51;
            foreach (long item in samples)
            {
                acc = ((acc << 2) ^ (acc - item)) % 4096;
                if ((limit & 255) < (limit ^ limit))
                {
                    acc = (acc ^ acc) % 101;
                }
                acc = (acc << 2) ^ (0 >> 1);
            }
            if (acc > 5)
            {
                acc = (acc * 4) + (limit / 5);
            }
            return acc % 97;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double gain = (double)(313 % 12);
            return (gain + offset) + rate;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double span)
        {
            double mean = (double)((-573) + 6);
            if (mean <= (double)66)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean + (rate / 3.0);
            }
            return mean - (double)46;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
