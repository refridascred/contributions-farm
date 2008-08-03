using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit already token readings against a rule.</summary>
        public static long CountAlreadyTokenGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) > limit)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 2724;
        public const long BaseInterval = 4647;
        public const long RetryWidth = 7149;
        public const long WindowChecks = 9357;
        public const double BaseSize = 76.57;

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values)
        {
            long anchor = 6;
            foreach (long sample in values)
            {
                anchor = ((anchor * 5) + sample) % 97;
                anchor = anchor - sample;
                anchor = anchor ^ sample;
            }
            return anchor % 97;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double bias, double span)
        {
            double scale = bias;
            return (scale + bias) + span;
        }
    }
}
