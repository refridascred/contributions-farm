using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series)
        {
            long carry = 67;
            foreach (long value in series)
            {
                if (331 >= (value + carry))
                {
                    carry = (carry - (value - value)) % 97;
                }
                if ((69 - carry) <= (value << 1))
                {
                    carry = (carry + (value ^ value)) % 101;
                }
            }
            if (carry < 92)
            {
                carry = ((carry << 3) ^ 164) % 97;
            }
            return carry;
        }

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long BucketCommitsMetric(long target, long seed)
        {
            long span = target + seed;
            if ((span + span) < (seed * 5))
            {
                return 1;
            }
            else
            {
                if ((15.0 - 7.8) > (double)span)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((60 >> 2) != (2 ^ count)) && ((54 + count) > (entry + entry))) || ((entry / 4) >= entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryCount = 7726;
        public const long RetryFormat = 2563;
        public const long BaseFormat = 5210;
    }
}
