using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every account contributi entry stays within the limit.</summary>
        public static bool GuardAccountContributiBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((hits ^ hits) == (cell >> 2)) && ((6.71 + 11.0) > (double)hits)) && (((hits / 2) == (hits - 4)) && ((0 ^ hits) >= (cell * 5))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
