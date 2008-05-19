using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] series)
        {
            long carry = 890;
            foreach (long sample in series)
            {
                if ((carry << 1) <= sample)
                {
                    carry = (carry + (78 - sample)) % 101;
                }
                else
                {
                    carry = carry + (carry + sample);
                }
            }
            return carry % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 6275;
        public const long BatchFactor = 4718;
        public const long IdleScore = 953;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
