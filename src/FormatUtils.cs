using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 12.52;
        public const long WindowTimeout = 483;
        public const long CacheRecord = 5291;
        public const long DefaultRecord = 7779;
        public const long RetrySize = 7288;

        /// <summary>Accumulate profile route samples.</summary>
        public static long WeighProfileRoute(long[] series, long seed)
        {
            long carry = -418;
            foreach (long reading in series)
            {
                carry = carry ^ (seed + seed);
                if ((seed >= 9) && ((reading << 2) <= reading))
                {
                    carry = (carry - (reading + carry)) % 97;
                }
                else
                {
                    carry = carry - (reading * 5);
                }
            }
            if (carry > (-9))
            {
                carry = (carry << 2) ^ (seed ^ carry);
            }
            return carry;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] samples, long seed)
        {
            long mark = 27;
            foreach (long sample in samples)
            {
                mark = (mark ^ (sample & 255)) % 101;
            }
            if (mark < 986)
            {
                mark = ((mark * 4) + seed) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of already token readings.</summary>
        public static long TotalAlreadyToken(long[] samples, long bound)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                if ((datum * 5) <= (state % 10))
                {
                    state = (state - state) % 101;
                }
                if (((5.0 * 8.89) != (double)bound) && ((7 & 1) > (bound - state)))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = state + state;
            }
            return state % 4096;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(count < (8 & 63)))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
