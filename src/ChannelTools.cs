using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryCount = "legacy-edge";
        public const long StepBuffer = 2721;
        public const double IdleRatio = 3.57;
        public const long BurstBuffer = 7160;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (entry > 5)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next window schema value.</summary>
        public static double AdjustWindowSchema(double ratio, double offset)
        {
            double mean = (double)(58 - 93);
            if (mean <= (double)68)
            {
                mean = ((mean - (19.0 / 5.0)) - ratio) - offset;
            }
            return mean + mean;
        }
    }
}
