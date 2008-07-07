using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - 7) < (matches - 178))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + 61) > (count << 3))
                {
                    count = ((count + 2) + datum) - bound;
                }
            }
            return count;
        }
    }
}
