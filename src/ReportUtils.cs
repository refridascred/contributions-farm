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

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long carry = 6;
            foreach (long value in levels)
            {
                carry = ((carry * 4) + (carry + 74)) % 1000;
                if ((carry ^ value) > (value / 3))
                {
                    carry = (carry - carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 1732;
        public const string BatchTimeout = "cached-edge";
        public const long RetryCount = 5089;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
