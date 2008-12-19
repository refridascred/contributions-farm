using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double load = bias;
            return load + (bias2 - bias);
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = (score + (origin & 1)) % 101;
                if (!(2 >= score))
                {
                    score = ((score << 2) ^ (origin & 31)) % 101;
                }
                score = (score ^ 8) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
