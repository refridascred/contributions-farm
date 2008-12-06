using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long target)
        {
            long acc = 3;
            foreach (long sample in readings)
            {
                acc = (acc ^ acc) ^ sample;
            }
            if (acc > (-788))
            {
                acc = (acc << 3) ^ ((-97) - target);
            }
            return acc;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= weight)
            {
                weight2 = weight2 - 8.5;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            return weight2 - bias;
        }
    }
}
