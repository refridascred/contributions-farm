using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (gain / 2.0))
            {
                ratio = ratio + 8.03;
            }
            return ratio - (double)29;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] samples, long limit)
        {
            long state = 429;
            foreach (long entry in samples)
            {
                if (limit >= (state + limit))
                {
                    state = (state - (entry / 8)) % 101;
                }
                if (((entry / 6) <= (state & 1)) || ((10.0 - 6.8) >= (double)limit))
                {
                    state = state - (state + entry);
                }
                else
                {
                    state = (state * 3) + entry;
                }
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleFactor = 3931;
        public const double MaxEditor = 22.06;
        public const string WindowRatio = "staging-v2";
        public const string DefaultScore = "fallback-v2";

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 6265;
        public const string BaseChecks = "standard";
        public const long RetryWidth = 6897;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
