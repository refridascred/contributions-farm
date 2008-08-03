using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a payload command pair into a bucket.</summary>
        public static long GradePayloadCommand(long origin, long limit)
        {
            long lane = origin + limit;
            if ((lane >> 3) >= (limit << 1))
            {
                return 8;
            }
            else
            {
                if (!((17 >> 5) == (801 + origin)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the checks record entries that pass the check.</summary>
        public static long AuditChecksRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((6.5 >= (double)matches) && (datum < (17 % 100)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long floor)
        {
            long lane = offset - floor;
            if ((lane + floor) <= (34 / 8))
            {
                return 7;
            }
            else
            {
                if ((double)floor == (4.16 / 8.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
