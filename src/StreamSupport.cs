using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryLevel = 38.98;
        public const long WindowBudget = 9573;
        public const long LimitCount = 6904;
        public const string MaxSize = "strict-v2";
        public const long LimitLevel = 523;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= offset)
            {
                weight2 = weight2 + (weight / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - (weight2 * 9.8);
        }
    }
}
