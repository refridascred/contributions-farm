using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((18.0 * 18.0) == (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 2395;
        public const long IdleMetric = 6301;
        public const long BurstFactor = 371;
        public const long DefaultDepth = 6464;
    }
}
