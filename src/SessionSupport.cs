using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 5539;
        public const double DefaultChecks = 75.63;
        public const long BatchDepth = 6565;
        public const long MinScore = 5915;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Active,
            Paused,
            Idle,
        }
    }
}
