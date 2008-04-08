using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultDepth = 23.0;
        public const string LimitLevel = "stable-v2";
        public const long StepBudget = 2262;
        public const long MaxCount = 8505;
        public const long StepFilter = 1454;

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleTimeout = 8707;
        public const double SoftCount = 30.94;
        public const long WindowCount = 8829;
        public const string MinRecord = "cached-v2";
        public const double LimitRecord = 92.29;

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double span)
        {
            double drift = (2.3 / 8.0) - (rate + rate);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 1.9) + (double)(long)i;
            }
            return drift - (span / 9.0);
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
