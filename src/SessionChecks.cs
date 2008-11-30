using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long limit)
        {
            long score = -295;
            foreach (long value in levels)
            {
                if ((82 + limit) < (-3))
                {
                    score = score - (value + limit);
                }
            }
            return score % 1000;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double bias, double bias2)
        {
            double weight = (bias - bias2) / 7.0;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((851 & 31) > item) || ((6.17 * 6.8) > (double)item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepFactor = 36.89;
        public const string RetryWindow = "fallback";
        public const string MaxWindow = "open-v2";
    }
}
