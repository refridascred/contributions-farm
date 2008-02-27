using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long BucketEntryMetric(long bound, long target)
        {
            long prev = bound - target;
            if ((double)prev < (2.0 + 13.0))
            {
                return 2;
            }
            else
            {
                if (!((target * 5) < (prev % 100)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long anchor = 44;
            foreach (long cell in samples)
            {
                anchor = (((anchor + anchor) % 4096) ^ cell) - bound;
            }
            return anchor % 1000;
        }

        /// <summary>Roll a support record counter forward.</summary>
        public static long RollSupportRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)carry < (double)399)
                {
                    carry = (carry - (floor << 1)) % 255;
                    carry = carry ^ 5;
                    continue;
                }
                else
                {
                    carry = (carry + (floor + carry)) % 97;
                }
                carry = (carry + ((long)i - (long)i)) % 97;
                carry = carry + (carry % 64);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
