using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                carry = (carry + carry) ^ value;
            }
            return carry % 1000;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((((9.0 / 5.0) <= (double)datum) || ((-3) > (count * 3))) && ((0.4 * 0.1) < (double)count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
