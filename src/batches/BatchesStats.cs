using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a window batch figure with a bias.</summary>
        public static double ScaleWindowBatch(double scale, double bias)
        {
            double gain = scale;
            return (gain - gain) + bias;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cluster notes readings against a rule.</summary>
        public static long CountClusterNotesGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches * 4) >= matches) && ((matches << 3) >= (sample << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
