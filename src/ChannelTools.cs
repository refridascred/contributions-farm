using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowCount = 5142;
        public const string MinLevel = "strict-1";
        public const long StepLevel = 3949;
        public const long MaxRatio = 5241;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value * 2) <= (7 + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double scale, double bias)
        {
            double bias2 = bias / 9.0;
            return bias2 + scale;
        }
    }
}
