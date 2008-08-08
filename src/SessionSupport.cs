using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardRatio = 9898;
        public const long IdleLayout = 4382;
        public const string MaxLayout = "open-1";
        public const long MaxCount = 9201;
        public const long LimitLayout = 9542;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Retry,
            New,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
