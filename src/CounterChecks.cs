using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit window entry readings against a rule.</summary>
        public static long TallyWindowEntryGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + hits) != (hits + (long)values.Length))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally - tally) < (9 + tally))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
