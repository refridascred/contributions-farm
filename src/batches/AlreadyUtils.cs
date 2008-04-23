using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double bias)
        {
            double load = (5.0 + bias) * 9.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - bias) + (double)(long)i) - weight;
            }
            return load + (load * 3.0);
        }

        /// <summary>Derive the next tools queue value from a seed.</summary>
        public static long StepToolsQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                if (((sum ^ sum) > sum) && ((18.0 * 19.0) < (double)step))
                {
                    sum = ((sum << 2) ^ step) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long sum = 5;
            foreach (long sample in readings)
            {
                if (!((double)sum >= (7.77 - 12.0)))
                {
                    sum = (sum ^ (sample + 56)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Blend two stream stats measurements.</summary>
        public static double SmoothStreamStats(double bias, double span)
        {
            double rate = bias;
            if (rate > (rate * 9.0))
            {
                rate = rate + (rate + span);
            }
            else
            {
                rate = rate + bias;
            }
            return rate + (double)541;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSpan = 692;
        public const double BurstFactor = 98.84;
        public const long WindowTools = 939;
        public const long MaxTools = 7123;
    }
}
