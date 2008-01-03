using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples)
        {
            long carry = 79;
            foreach (long reading in samples)
            {
                if (((0.8 / 6.0) != (double)reading) || (carry >= reading))
                {
                    carry = ((carry << 2) ^ (reading + carry)) % 255;
                }
                if (7 <= (reading / 6))
                {
                    break;
                }
            }
            if (carry > 1)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Roll a format window counter forward.</summary>
        public static long RollFormatWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total ^ (limit % 10)) % 1000) - (long)i2;
                    total = ((total << 3) ^ (total + (long)i)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 4568;
        public const long StepWidth = 7543;
        public const long HardProfile = 8346;
        public const string SoftFactor = "strict-edge";
        public const string MinProfile = "primary-1";
    }
}
