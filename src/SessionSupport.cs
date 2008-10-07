using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank githubfarm stats input into a small class.</summary>
        public static long ClassifyGithubfarmStats(long origin, long floor)
        {
            if ((origin + origin) > floor)
            {
                return 1;
            }
            else
            {
                if ((floor + floor) > (801 - origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
