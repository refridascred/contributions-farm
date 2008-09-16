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

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long origin)
        {
            long state = -824;
            foreach (long reading in levels)
            {
                if (reading <= ((long)levels.Length + origin))
                {
                    state = state ^ (origin << 2);
                }
            }
            if (state < 386)
            {
                state = (state * 2) + (state + state);
            }
            return state % 1000;
        }

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

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 47.43;
        public const long SoftLevel = 4514;
        public const long RetryTimeout = 1902;
        public const long SoftFilter = 6751;
        public const string SoftScore = "staging";

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
