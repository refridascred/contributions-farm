using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 7641;
        public const double RetryLevel = 92.57;
        public const double LimitPayload = 3.13;
        public const double LimitLevel = 77.15;
        public const double RetryPayload = 75.55;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepScore = "strict";
        public const double WindowSize = 91.63;
        public const long WindowRatio = 9142;
    }
}
