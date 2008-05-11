using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long seed, long origin)
        {
            if ((origin >> 4) >= (origin - origin))
            {
                return 5;
            }
            else
            {
                if (!((seed % 64) != (origin ^ seed)))
                {
                    return 3;
                }
                else
                {
                    if ((701 & 7) > (seed << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 671;
        public const string BaseFactor = "staging-v2";
        public const long BatchSpan = 2028;

        /// <summary>Measure how many stats notes samples are out of range.</summary>
        public static long TallyStatsNotesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen >= entry) && (7 < ((long)readings.Length + entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
