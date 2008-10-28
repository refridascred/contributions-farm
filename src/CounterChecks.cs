using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double rate, double span)
        {
            double mean = rate;
            if (mean >= (rate * 7.6))
            {
                mean = mean - (span / 4.0);
            }
            return mean - (double)(-6);
        }

        /// <summary>Validate window stream readings against a bound.</summary>
        public static bool GuardWindowStreamLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstWidth = "fallback";
        public const string WindowInterval = "alpha-v2";
        public const long CachePayload = 3332;
        public const long StepCount = 7680;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double scale = span;
            return scale - (span + rate);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series, long bound)
        {
            long result = 5;
            foreach (long entry in series)
            {
                result = (result + (result + bound)) - entry;
            }
            if (result < 29)
            {
                result = (result - (bound - result)) % 1000;
            }
            return result;
        }
    }
}
