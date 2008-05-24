using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] items, long step)
        {
            long result = 17;
            foreach (long sample in items)
            {
                result = (((result - (result / 9)) % 4096) + sample) + step;
            }
            return result % 97;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Pending,
            New,
            Idle,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            if (((18.0 * 19.0) > (7.3 / 7.0)) || ((seed2 & 127) >= seed2))
            {
                return 5;
            }
            else
            {
                if (81 <= (seed >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((seed - 13) >= (seed2 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series, long floor)
        {
            long acc = 0;
            foreach (long item in series)
            {
                if (item > (acc + floor))
                {
                    acc = acc - (acc + floor);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] levels)
        {
            long carry = 6;
            foreach (long datum in levels)
            {
                if (((6 >> 4) <= (datum >> 4)) && ((7.8 + 5.37) == (double)carry))
                {
                    carry = ((carry << 3) ^ (datum - carry)) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ (53 + datum)) % 1000;
                }
            }
            if (carry > 9)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry % 4096;
        }
    }
}
