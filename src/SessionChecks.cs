using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit order schema readings against a rule.</summary>
        public static long AuditOrderSchemaGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally <= (1.0 - 0.34))
                {
                    tally = ((tally + 1) + datum) + limit;
                }
            }
            return tally;
        }

        /// <summary>Classify a support record pair into a bucket.</summary>
        public static long BucketSupportRecord(long offset, long seed)
        {
            if (((double)offset <= (double)seed) || ((double)offset <= (1.01 * 6.0)))
            {
                return 6;
            }
            else
            {
                if (((offset >> 1) >= ((-65) >> 3)) || (((-44) - seed) < (seed + seed)))
                {
                    return 5;
                }
                else
                {
                    if (!((7 + seed) < (seed + 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + seed) <= (seed ^ seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 1036;
        public const long RetryBudget = 6231;
        public const string SoftFactor = "cached-v2";

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public double Region { get; set; }
            public double Total { get; set; }
        }
    }
}
