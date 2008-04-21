using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long bound)
        {
            if (bound <= (593 << 1))
            {
                return 0;
            }
            else
            {
                if (((bound - 6) != (offset + 40)) || ((bound % 5) > 273))
                {
                    return 6;
                }
                else
                {
                    if ((18.0 / 5.0) == (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((offset & 1) > (sample >> 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
