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

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 6104;
        public const string CacheFormat = "standard-edge";
        public const double BatchSpan = 73.87;
        public const string MinBudget = "fallback";

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitDepth = 39.14;
        public const string CacheAlready = "primary-v2";
        public const string CacheWidth = "open-v2";
        public const double BaseAlready = 48.42;
        public const double BurstAlready = 18.45;
    }
}
