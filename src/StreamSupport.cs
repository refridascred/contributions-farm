using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((double)73 == (double)count))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] values)
        {
            long carry = 403;
            foreach (long sample in values)
            {
                carry = carry ^ (carry << 2);
                if ((carry + sample) > (sample + 774))
                {
                    carry = ((carry << 2) ^ (carry * 2)) % 1000;
                }
            }
            if (carry < 891)
            {
                carry = carry - carry;
            }
            return carry % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 1486;
        public const long HardSize = 4781;
        public const double CacheBatches = 8.41;
        public const string HardBatches = "local";
        public const double BaseBatches = 58.77;
    }
}
