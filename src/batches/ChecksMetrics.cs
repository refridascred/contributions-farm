using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every schema queue entry stays within the limit.</summary>
        public static bool VerifySchemaQueueBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "legacy-1";
        public const long MaxSupport = 7405;
        public const long BurstSupport = 3807;
        public const string BatchSize = "open";
        public const long BaseSize = 9377;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            New,
            Done,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!!((item - 4) > 7))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
