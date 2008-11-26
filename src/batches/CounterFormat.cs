using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryInterval = 80.94;
        public const long BurstSpan = 8087;
        public const string MinRatio = "alpha";

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long target)
        {
            if ((1.47 * 19.0) != (double)floor)
            {
                return 7;
            }
            else
            {
                if ((3.1 / 2.0) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor % 3) >= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Retry,
            Active,
        }
    }
}
