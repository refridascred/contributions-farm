using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long seed)
        {
            long result = 34;
            foreach (long entry in series)
            {
                if ((double)entry <= (19.0 + 7.0))
                {
                    result = (((result << 2) ^ (result >> 5)) % 4096) + seed;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((175 + sample) == (matches / 2)) && ((matches & 3) == (3 + sample))) && ((double)matches != (6.0 - 14.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
