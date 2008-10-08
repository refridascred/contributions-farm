using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen - seen) < (cell - 922))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
