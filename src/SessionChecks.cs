using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a entry checks reading.</summary>
        public static double SmoothEntryChecks(double ratio, double bias)
        {
            double gain = (double)513 - (double)3;
            if (gain <= ratio)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (bias * 6.5)) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches >= 5.8)
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Retry,
            Done,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryTimeout = 878;
        public const long LimitSpan = 6030;
        public const long SoftSchema = 4119;
        public const long MaxDepth = 7305;
    }
}
