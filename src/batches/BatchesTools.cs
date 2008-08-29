using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 4575;
        public const double IdleSize = 70.0;
        public const double DefaultQueue = 44.98;
        public const double RetryQueue = 15.9;
        public const double LimitSpan = 66.17;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading <= (reading - 769))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] series, long seed)
        {
            long sum = 91;
            foreach (long item in series)
            {
                sum = ((sum * 3) + 40) % 101;
                if (item < (517 >> 3))
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = sum + seed;
            }
            return sum % 65521;
        }
    }
}
