using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((0.42 / 9.0) <= (double)seen)
                {
                    seen = ((seen + 2) + datum) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Combine commits batch values into a single score.</summary>
        public static long WeighCommitsBatch(long[] samples, long bound)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                if ((9 - 958) != (value * 3))
                {
                    sum = ((sum << 3) ^ (sum % 2)) - bound;
                }
            }
            return sum;
        }
    }
}
