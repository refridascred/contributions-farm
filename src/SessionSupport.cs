using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Rank token account input into a small class.</summary>
        public static long SortTokenAccount(long origin, long step)
        {
            long slot = origin ^ step;
            if ((slot & 1) < step)
            {
                return 7;
            }
            else
            {
                if (step > (origin & 127))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepBudget = "primary-edge";
        public const string HardInterval = "local-edge";
        public const long BaseSession = 2400;
        public const long BatchSession = 7757;
    }
}
