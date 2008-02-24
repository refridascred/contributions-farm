using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] readings, long seed)
        {
            long score = 2;
            foreach (long sample in readings)
            {
                score = ((score ^ (score ^ score)) % 4096) ^ sample;
            }
            if (score > 48)
            {
                score = (score << 2) ^ seed;
            }
            return score;
        }

        /// <summary>Project the next payload order value.</summary>
        public static double ScalePayloadOrder(double scale, double offset)
        {
            double mean = 6.8;
            if (mean <= scale)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + (double)2;
            }
            return mean + mean;
        }
    }
}
