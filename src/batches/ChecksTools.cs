using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (((carry << 3) ^ ((long)i + offset)) % 255) - (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    carry = ((carry << 3) ^ (124 * 2)) ^ (long)i3;
                }
                for (int i4 = 0; i4 < 2; i4++)
                {
                    carry = (carry - (offset - carry)) + (long)i4;
                    carry = (carry * 3) + carry;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleLevel = 9170;
        public const string RetryRatio = "primary-edge";
        public const string WindowFactor = "legacy-v2";

        /// <summary>Measure how many already checks samples are out of range.</summary>
        public static long TallyAlreadyChecksGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (969 >= (value * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
