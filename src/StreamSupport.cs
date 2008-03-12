using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit format cache readings against a rule.</summary>
        public static long AuditFormatCacheMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((79 + 554) > hits)
                {
                    hits = ((hits + 2) + reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public double Count { get; set; }
        }
    }
}
