using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Paused,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long origin, long target)
        {
            long offset = origin - target;
            if ((offset / 7) < ((-513) ^ 283))
            {
                return 8;
            }
            else
            {
                if (((origin << 1) < (8 + offset)) || (origin < (offset >> 2)))
                {
                    return 3;
                }
                else
                {
                    if (offset > target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine checks payload values into a single score.</summary>
        public static long CombineChecksPayload(long[] values)
        {
            long anchor = 199;
            foreach (long reading in values)
            {
                anchor = (anchor ^ (reading - 426)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the report checks entries that pass the check.</summary>
        public static long AuditReportChecksHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((double)datum < (0.5 / 8.0)) || ((seed * 5) == (3 >> 2)))
                {
                    tally = tally + 3;
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
