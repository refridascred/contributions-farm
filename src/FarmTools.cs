using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double rate = span;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (double)13) + (double)(long)i) + bias;
            }
            return rate + 1.0;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchSpan = "fallback";
        public const string StepStream = "fallback-edge";
        public const long HardInterval = 3329;
        public const long WindowLevel = 9762;
        public const long HardStream = 3666;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((floor - matches) < (matches * 5))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
