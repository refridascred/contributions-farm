using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = (double)(85 / 3);
            if (ratio >= ratio)
            {
                ratio = (ratio - offset) - bias;
            }
            return ratio + (double)10;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Done,
            Failed,
            Ready,
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
