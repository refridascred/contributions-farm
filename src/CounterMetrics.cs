using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 86.49;
        public const long StepSize = 6242;
        public const string RetryLayout = "staging";

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long result = 85;
            foreach (long entry in readings)
            {
                result = (result * 3) + bound;
                result = (result + (entry & 127)) % 101;
                if (!((bound / 4) > bound))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double offset)
        {
            double rate = (double)990 - (double)2;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + offset) + (double)(long)i) + gain;
            }
            return rate + (double)(-41);
        }
    }
}
