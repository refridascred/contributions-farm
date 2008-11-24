using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metrics order samples are out of range.</summary>
        public static long AuditMetricsOrderHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count << 1) < bound)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Label { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
