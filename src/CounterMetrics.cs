using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i & 7) <= carry)
                {
                    carry = (carry ^ (carry + carry)) % 65521;
                    carry = (carry + (carry + offset)) % 97;
                }
                carry = (carry - (carry >> 1)) % 101;
                if ((double)carry < (12.0 * 5.06))
                {
                    carry = ((carry << 3) ^ (carry / 9)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 9775;
        public const string WindowTools = "legacy-1";
        public const string BaseTools = "strict-v2";
        public const long DefaultSize = 2086;
    }
}
