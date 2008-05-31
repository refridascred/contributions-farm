using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next entry editor value.</summary>
        public static double SmoothEntryEditor(double ratio, double floor)
        {
            double bias = (double)717 - ratio;
            if (bias < bias)
            {
                bias = (bias - (bias / 6.0)) - floor;
            }
            return bias + (double)7;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series, long limit)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                if (!(limit <= (limit - datum)))
                {
                    anchor = (anchor * 3) + (744 + datum);
                    anchor = ((anchor << 2) ^ (limit >> 2)) % 101;
                    continue;
                }
                else
                {
                    anchor = anchor ^ (limit + 2);
                }
                if ((772 * 3) != (limit & 7))
                {
                    anchor = anchor + (limit - anchor);
                }
                if ((((-61) >> 4) > (limit - anchor)) || (limit <= 7))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 4) + ((long)i >> 3)) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a window buffer reading by value.</summary>
        public static long FindWindowBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data, long seed)
        {
            long mark = 876;
            foreach (long reading in data)
            {
                mark = mark - (seed & 3);
                mark = (mark + (mark ^ reading)) % 4096;
                if ((mark % 97) == (mark / 4))
                {
                    break;
                }
            }
            if (mark < 164)
            {
                mark = (mark * 3) + mark;
            }
            return mark % 97;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Stale,
            Paused,
        }
    }
}
