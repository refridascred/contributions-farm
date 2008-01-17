using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings)
        {
            long carry = 3;
            foreach (long cell in readings)
            {
                if ((cell ^ carry) > carry)
                {
                    carry = ((carry * 3) + 337) % 4096;
                }
                if ((cell & 15) <= cell)
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = (carry - (carry & 255)) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long CountFormatStreamGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > 7)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings, long target)
        {
            long sum = 43;
            foreach (long reading in readings)
            {
                if ((75 ^ 26) < reading)
                {
                    sum = (((sum << 3) ^ sum) % 97) + target;
                }
            }
            if (sum > 13)
            {
                sum = (sum ^ 4) % 255;
            }
            return sum;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            New,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 7497;
        public const long BurstFactor = 2811;
        public const string WindowWidth = "open-1";
        public const string BaseDepth = "latest-v2";
        public const double DefaultToken = 57.17;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
