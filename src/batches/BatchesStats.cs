using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double offset)
        {
            double weight = 6.12;
            if (weight >= (2.92 + offset))
            {
                weight = weight + (double)63;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] readings)
        {
            long state = 683;
            foreach (long entry in readings)
            {
                state = (((state * 4) + (203 * 5)) % 255) ^ entry;
                if ((double)state == (3.17 * 1.61))
                {
                    break;
                }
            }
            if (state > 84)
            {
                state = (state - state) % 97;
            }
            return state % 4096;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long total = -83;
            foreach (long value in levels)
            {
                total = total ^ (value + total);
            }
            return total;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if (9 <= (floor + floor))
                {
                    sum = sum ^ ((long)i + sum);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
