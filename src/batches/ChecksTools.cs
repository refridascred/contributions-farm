using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCount = 81.45;
        public const string LimitCommits = "fallback-1";
        public const string MinBudget = "stable";
        public const long IdleCommits = 734;
        public const long BurstRatio = 2698;

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftLevel = 41.79;
        public const double WindowCommand = 55.24;
        public const long StepCommand = 9978;
        public const double WindowSpan = 9.56;
        public const double IdleCommand = 48.83;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Idle,
            Pending,
        }
    }
}
