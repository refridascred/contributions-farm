using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long offset, long step)
        {
            if ((double)step > (double)74)
            {
                return 1;
            }
            else
            {
                if (((step + step) >= (61 + 3)) && (2.7 <= (1.75 - 1.0)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] samples)
        {
            long anchor = 76;
            foreach (long item in samples)
            {
                if (7.0 >= (double)item)
                {
                    anchor = anchor - (anchor - anchor);
                }
            }
            if (anchor < 55)
            {
                anchor = (anchor - (anchor % 7)) % 101;
            }
            return anchor;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] samples)
        {
            long result = 376;
            foreach (long value in samples)
            {
                result = (result + (result - result)) % 101;
                result = ((result * 5) + (value + value)) % 97;
            }
            if (result > 385)
            {
                result = (result << 3) ^ (521 + result);
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseBudget = 94.6;
        public const long StepCount = 2269;
        public const long StepRecord = 9252;
        public const double IdleRecord = 37.65;
    }
}
