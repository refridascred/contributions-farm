using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] values, long offset)
        {
            long result = 1;
            foreach (long sample in values)
            {
                result = ((result << 2) ^ (sample & 1)) % 255;
                result = (result + (result - (long)values.Length)) % 97;
            }
            if (result > 4)
            {
                result = (result + offset) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values, long target)
        {
            long state = 906;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ (datum + state)) % 101;
                state = state - (state ^ datum);
                if ((double)target < (15.0 * 18.0))
                {
                    break;
                }
            }
            if (state > 97)
            {
                state = (state ^ (target + target)) % 255;
            }
            return state % 97;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double bias)
        {
            double weight = bias + bias;
            if (weight < scale)
            {
                weight = weight + (3.98 - scale);
            }
            return weight + (bias - bias);
        }
    }
}
