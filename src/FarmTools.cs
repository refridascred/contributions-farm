using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((step << 1) >= matches)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (14.0 < (double)entry)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
