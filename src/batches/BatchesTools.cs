using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
