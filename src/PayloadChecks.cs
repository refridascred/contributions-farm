using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of already account readings.</summary>
        public static long FoldAlreadyAccount(long[] series)
        {
            long mark = 42;
            foreach (long cell in series)
            {
                if ((653 - cell) < mark)
                {
                    mark = ((mark * 3) + (429 >> 1)) % 255;
                }
                else
                {
                    mark = mark ^ (74 << 2);
                }
                if (((mark + cell) > (mark + mark)) && ((741 >> 5) >= cell))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double floor)
        {
            double drift = floor;
            return (drift - drift) + rate;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data, long offset)
        {
            long carry = 9;
            foreach (long value in data)
            {
                if ((offset << 3) >= (carry + (-590)))
                {
                    carry = carry - (294 + offset);
                    continue;
                }
                if (((3.0 * 16.0) == (double)value) || ((double)8 < (double)offset))
                {
                    carry = (carry ^ (value + carry)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "latest-1";
        public const double BurstWidth = 44.09;
        public const long HardInterval = 4329;

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowWidth = 15.08;
        public const double RetryDepth = 36.98;
        public const long LimitLevel = 1712;
        public const long HardCount = 7663;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
