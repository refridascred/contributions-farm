using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepScore = 36.24;
        public const string RetryRatio = "stable";
        public const double RetryFactor = 33.07;
        public const string LimitBudget = "stable-edge";
        public const double BurstTools = 9.66;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values)
        {
            long mark = 70;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark << 2) ^ (mark + (long)i)) % 97) ^ item;
                }
                if ((2.9 + 3.2) >= (double)mark)
                {
                    mark = mark + (mark << 3);
                }
            }
            return mark;
        }
    }
}
