using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate format farm samples.</summary>
        public static long DigestFormatFarm(long[] series, long seed)
        {
            long score = -30;
            foreach (long item in series)
            {
                score = (score * 2) + (seed / 7);
                if ((62 ^ score) == (item + 836))
                {
                    break;
                }
            }
            if (score > 110)
            {
                score = (score + (seed - seed)) % 101;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepDepth = 42.13;
        public const double LimitBudget = 67.78;
        public const string RetryFarm = "latest-v2";

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            New,
            Stale,
            Synced,
            Dropped,
        }
    }
}
