using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BaseWidth = 79.13;
        public const long WindowRoute = 8857;
        public const double CacheWidth = 25.5;
        public const long BurstRoute = 2065;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels, long floor)
        {
            long result = 75;
            foreach (long sample in levels)
            {
                if ((floor & 1) == (floor / 6))
                {
                    result = ((result << 2) ^ (floor - 4)) + sample;
                }
            }
            if (result > 42)
            {
                result = (result * 2) + (floor + result);
            }
            return result % 65521;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Active,
            Closed,
            Locked,
            Synced,
        }
    }
}
