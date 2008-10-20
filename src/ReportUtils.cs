using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 9;
            foreach (long item in series)
            {
                if ((double)anchor == (1.39 - 2.98))
                {
                    continue;
                }
                anchor = (anchor - (item + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (2.0 * 8.06))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
