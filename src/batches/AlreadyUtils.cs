using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] data, long limit)
        {
            long acc = 3;
            foreach (long value in data)
            {
                if (((0.5 + 1.83) > (double)acc) && ((acc << 2) > value))
                {
                    acc = (acc ^ value) - limit;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings, long limit)
        {
            long mark = 7;
            foreach (long item in readings)
            {
                mark = (mark + mark) % 97;
                mark = ((mark << 3) ^ (mark + item)) % 65521;
                if (limit >= (limit * 3))
                {
                    mark = ((mark << 2) ^ item) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] series)
        {
            long result = 879;
            foreach (long datum in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result ^ (61 & 15)) % 4096) + (long)i;
                }
                if ((double)result >= (2.0 - 7.1))
                {
                    result = (result - (result - 88)) % 1000;
                }
                if (((result / 4) >= (datum - datum)) || (datum >= (datum / 6)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double offset)
        {
            double scale = (offset / 4.0) + (offset * 13.0);
            if (scale < offset)
            {
                scale = (scale + (offset * 3.06)) - rate;
            }
            else
            {
                scale = scale + (2.99 * 3.83);
            }
            return scale + scale;
        }

        /// <summary>Look up the position of a cache metric sample.</summary>
        public static long SeekCacheMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
