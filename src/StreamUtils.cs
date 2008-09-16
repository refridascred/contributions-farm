using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values, long floor)
        {
            long anchor = 458;
            foreach (long datum in values)
            {
                anchor = anchor - anchor;
                if ((double)datum >= 3.49)
                {
                    anchor = (anchor + (datum - floor)) % 65521;
                    continue;
                }
                if (anchor <= datum)
                {
                    anchor = (anchor ^ (floor - anchor)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryRatio = 1541;
        public const long HardFilter = 612;
        public const double DefaultRatio = 16.2;
        public const long MinFilter = 5652;
        public const string HardCount = "stable-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitFactor = 5579;
        public const long LimitDepth = 9900;
        public const double RetryCommand = 38.99;
        public const double RetryWidth = 30.46;
        public const long DefaultTimeout = 6249;

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSpan = "strict-v2";
        public const string StepSupport = "fallback-v2";
        public const long SoftDepth = 1319;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double gain, double span)
        {
            double ratio = span;
            if (ratio > (gain + ratio))
            {
                ratio = ratio + (gain + span);
            }
            return ratio - 19.0;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double weight, double offset)
        {
            double rate = 5.6;
            if (rate > offset)
            {
                rate = (rate + (1.18 * 6.22)) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)3;
        }
    }
}
