using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 94;
            foreach (long cell in samples)
            {
                total = (total - cell) % 97;
            }
            return total % 65521;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Active,
            New,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((value + matches) >= value) || ((6 + matches) <= matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
