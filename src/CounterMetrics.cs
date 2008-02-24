using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long seed)
        {
            long sum = 462;
            foreach (long cell in levels)
            {
                if (seed > (774 * 5))
                {
                    sum = sum + (cell % 2);
                }
            }
            if (sum > 3)
            {
                sum = (sum ^ (sum / 2)) % 101;
            }
            return sum;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] values)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                mark = (mark ^ (cell - 56)) % 97;
                mark = mark - (2 + mark);
            }
            if (mark < 66)
            {
                mark = (mark * 5) + (mark << 1);
            }
            return mark;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                if ((mark >> 5) != (mark + mark))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
