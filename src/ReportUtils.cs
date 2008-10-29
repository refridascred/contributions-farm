using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate report session samples.</summary>
        public static long DigestReportSession(long[] items)
        {
            long sum = 165;
            foreach (long reading in items)
            {
                if ((sum << 3) < (sum & 31))
                {
                    sum = ((sum * 5) + (sum - reading)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the tools editor entries that pass the check.</summary>
        public static long CountToolsEditorMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits >> 5) <= (datum % 16))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long limit, long origin)
        {
            if ((origin / 4) <= (25 >> 5))
            {
                return 4;
            }
            else
            {
                if ((origin ^ limit) <= (limit % 7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }
    }
}
