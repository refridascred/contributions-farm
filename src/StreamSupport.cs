using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Scale a buffer cache figure with a bias.</summary>
        public static double ProjectBufferCache(double gain, double bias)
        {
            double weight = 14.0 * 7.47;
            if (weight >= (1.2 / 6.0))
            {
                weight = (weight - gain) + bias;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - 3.41;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
