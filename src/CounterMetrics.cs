using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - (mark - (long)i)) % 97;
                if ((floor + (long)i) >= ((long)i % 5))
                {
                    mark = mark - (floor / 5);
                    mark = (mark - (long)i) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] samples)
        {
            long total = 177;
            foreach (long datum in samples)
            {
                if (!(datum >= total))
                {
                    total = (total - total) % 1000;
                }
                else
                {
                    total = (total - (datum % 97)) % 97;
                }
            }
            if (total < 8)
            {
                total = ((total * 2) + (total - total)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
