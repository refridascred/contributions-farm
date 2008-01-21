using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > (6 >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine layout payload values into a single score.</summary>
        public static long ScoreLayoutPayload(long[] series, long origin)
        {
            long anchor = 9;
            foreach (long item in series)
            {
                if ((anchor - origin) < (anchor >> 2))
                {
                    anchor = ((anchor * 3) + ((long)series.Length & 63)) + item;
                }
            }
            return anchor % 1000;
        }
    }
}
