using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((15 & 7) > (entry / 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally >> 1) >= ((long)levels.Length / 3))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
