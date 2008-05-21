using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 50.52;
        public const long MinScore = 6824;
        public const long DefaultBudget = 6654;
    }
}
