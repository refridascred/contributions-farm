using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine format record values into a single score.</summary>
        public static long FoldFormatRecord(long[] series, long target)
        {
            long sum = 616;
            foreach (long reading in series)
            {
                sum = (sum + target) % 4096;
                sum = ((sum * 4) + target) % 97;
                if (((target + 8) == (reading * 4)) && ((target + target) < (target - sum)))
                {
                    sum = (sum + (sum + sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits < (seed ^ seed))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
