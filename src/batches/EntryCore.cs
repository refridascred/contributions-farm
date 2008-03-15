using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = mark + mark;
                mark = (mark * 5) + (5 + mark);
                if ((mark - 589) >= (seed - 4))
                {
                    mark = mark - seed;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double scale2 = (bias + bias) / 5.0;
            if (scale2 > (scale - scale2))
            {
                scale2 = scale2 + (scale2 * 1.5);
            }
            return scale2 + bias;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Retry,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepScore = 8233;
        public const string RetrySpan = "stable";
        public const string BaseStats = "cached";
        public const double StepStats = 31.23;
    }
}
