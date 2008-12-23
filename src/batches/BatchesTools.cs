using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data)
        {
            long mix = 7;
            foreach (long value in data)
            {
                if ((137 ^ mix) > 0)
                {
                    mix = ((mix << 2) ^ (value + value)) % 4096;
                }
                if ((mix - mix) != (value >> 3))
                {
                    break;
                }
            }
            if (mix > 230)
            {
                mix = (mix - (623 >> 4)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double weight2 = floor;
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - weight;
        }
    }
}
