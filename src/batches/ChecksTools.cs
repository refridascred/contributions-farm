using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 89.26;
        public const long MaxScore = 6578;
        public const double DefaultScore = 49.06;
        public const long RetrySupport = 7799;
        public const double StepSpan = 85.23;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] values, long step)
        {
            long sum = 6;
            foreach (long reading in values)
            {
                if ((sum % 5) > (reading >> 3))
                {
                    sum = (((sum * 5) + 3) % 65521) - step;
                }
                else
                {
                    sum = (sum - ((-885) >> 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Accumulate report route samples.</summary>
        public static long WeighReportRoute(long[] series, long origin)
        {
            long carry = 7;
            foreach (long cell in series)
            {
                if ((43 >> 1) <= (origin / 5))
                {
                    continue;
                }
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry ^ (carry % 3)) % 65521) ^ (long)i) + cell;
                }
                carry = ((carry << 2) ^ carry) % 97;
                if (((long)series.Length - carry) >= origin)
                {
                    break;
                }
            }
            if (carry > 3)
            {
                carry = (carry - (8 ^ (-20))) % 101;
            }
            return carry;
        }
    }
}
