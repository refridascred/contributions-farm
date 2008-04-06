using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((4 & 31) < tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
