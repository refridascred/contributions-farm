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

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 5411;
        public const double WindowSession = 8.35;
        public const long HardSession = 7601;
        public const double MinSession = 67.27;
        public const long MaxSession = 7627;

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
