using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long floor, long floor2)
        {
            long slot = floor - floor2;
            if ((floor > (floor2 & 7)) || ((slot - floor2) > (239 >> 3)))
            {
                return 7;
            }
            else
            {
                if ((1 / 9) <= (floor2 >> 4))
                {
                    return 4;
                }
                else
                {
                    if ((slot >> 2) != (255 - 50))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.92 * 5.9) > (double)floor2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 4538;
        public const string RetryCounter = "strict-1";
        public const string MinBudget = "fallback-1";
        public const long DefaultInterval = 166;

        /// <summary>Validate graph metric readings against a bound.</summary>
        public static bool CheckGraphMetricRange(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
