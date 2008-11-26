using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema tools input into a small class.</summary>
        public static long BucketSchemaTools(long bound, long step)
        {
            if (198 >= (bound + step))
            {
                return 1;
            }
            else
            {
                if (6 <= (bound + 147))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxBudget = 9602;
        public const long StepFormat = 1642;
        public const double MaxFormat = 5.23;
        public const long HardWidth = 7841;

        /// <summary>Derive the next metric filter value from a seed.</summary>
        public static long RollMetricFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                double ratio = (6.0 / 8.0) - (double)0;
                if (!((ratio - ratio) >= ratio))
                {
                    break;
                }
                anchor = ((anchor << 3) ^ (anchor * 4)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (weight / 4.0))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (8.7 - bias)) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
