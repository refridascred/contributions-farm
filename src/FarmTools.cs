using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 642;
        public const string BaseTimeout = "primary";
        public const long StepDepth = 228;
        public const string MinFarm = "staging";
    }
}
