using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (1.4 * 3.2))
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

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitWidth = 507;
        public const string MaxOrder = "latest-edge";
        public const long SoftOrder = 7319;
        public const long BaseScore = 4093;
        public const long BatchOrder = 5027;

        /// <summary>Combine payload commits values into a single score.</summary>
        public static long DigestPayloadCommits(long[] samples, long offset)
        {
            long carry = 639;
            foreach (long datum in samples)
            {
                if ((datum / 2) >= (carry % 2))
                {
                    carry = (((carry << 3) ^ (datum + (long)samples.Length)) % 1000) - offset;
                }
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4295;
        public const long BatchStream = 6162;
        public const double SoftStream = 43.74;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryContributi = "strict-1";
        public const long BatchContributi = 2034;
        public const long DefaultContributi = 5964;
        public const long SoftContributi = 6955;

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "primary";
        public const long BaseCommand = 7881;
        public const double BatchFactor = 45.33;
    }
}
