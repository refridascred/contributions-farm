using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = (score - ((long)i ^ bound)) % 97;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Active,
            Failed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((floor - hits) >= (item >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
