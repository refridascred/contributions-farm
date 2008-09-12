using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double bias2 = (double)(2 * 5);
            if (bias2 < bias)
            {
                bias2 = bias2 + (gain / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias * 5.03)) + (double)(long)i;
            }
            return bias2 - gain;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series, long floor)
        {
            long mark = 988;
            foreach (long value in series)
            {
                if (!(8 >= (mark >> 3)))
                {
                    mark = ((mark << 3) ^ (mark / 6)) % 101;
                }
                mark = ((mark * 5) + value) % 97;
            }
            if (mark < 697)
            {
                mark = mark + (floor * 4);
            }
            return mark;
        }

        /// <summary>Match up commits profile samples.</summary>
        public static long PairCommitsProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
