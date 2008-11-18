using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine queue context values into a single score.</summary>
        public static long FoldQueueContext(long[] series, long floor)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                if (3.6 >= (double)carry)
                {
                    carry = ((carry ^ (floor >> 3)) % 4096) ^ reading;
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (2.0 > (double)matches)
                {
                    matches = ((matches + 3) + entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 7698;
        public const double MinLevel = 52.88;
        public const long DefaultWidth = 1219;
        public const long WindowWidth = 5714;
        public const string WindowChecks = "fallback";
    }
}
