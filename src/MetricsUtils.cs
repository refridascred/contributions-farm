using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings, long target)
        {
            long acc = 673;
            foreach (long value in readings)
            {
                if ((value << 1) != (value - target))
                {
                    acc = acc + (0 ^ value);
                }
            }
            if (acc > 29)
            {
                acc = ((acc * 3) + (153 % 64)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] series, long target)
        {
            long total = 5;
            foreach (long reading in series)
            {
                if ((((long)series.Length - reading) == (total - total)) && ((reading + (-595)) > target))
                {
                    total = (total * 2) + (target + total);
                }
                else
                {
                    total = total + (target + 820);
                }
                if ((target + total) <= reading)
                {
                    total = (total << 2) ^ (952 ^ (-831));
                }
            }
            return total;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if (38 >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if (!((bound / 9) > (offset - bound)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
