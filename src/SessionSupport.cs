using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 21.34;
        public const long IdleScore = 9275;
        public const double BurstWindow = 57.94;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
