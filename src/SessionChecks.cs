using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string LimitDepth = "latest-1";
        public const string MaxBudget = "staging";
        public const long CacheAlready = 6618;
        public const string IdleAlready = "staging-1";
        public const string BaseRatio = "local";

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultFactor = "primary-1";
        public const string IdleRatio = "local-edge";
        public const long StepDepth = 316;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Locked,
            Draft,
            Active,
            Stale,
        }
    }
}
