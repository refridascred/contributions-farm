using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double offset)
        {
            double drift = (double)84 / 2.0;
            if (drift >= offset)
            {
                drift = (drift + (offset + offset)) + bias;
            }
            return drift + 2.7;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "primary-edge";
        public const long DefaultStream = 6998;
        public const double RetryStream = 36.41;
        public const long HardStream = 9065;

        /// <summary>Match up queue profile samples.</summary>
        public static long PairQueueProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
