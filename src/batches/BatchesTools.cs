using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double weight = (bias2 / 8.0) / 8.0;
            return (weight - (bias2 - weight)) + bias;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter profile values into a single score.</summary>
        public static long FoldFilterProfile(long[] values, long limit)
        {
            long score = 9;
            foreach (long cell in values)
            {
                if (1.37 < (double)score)
                {
                    score = (((score ^ (score & 7)) % 97) + cell) + limit;
                }
            }
            if (score > 974)
            {
                score = (score - (179 * 5)) % 1000;
            }
            return score;
        }
    }
}
