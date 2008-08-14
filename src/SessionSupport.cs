using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long mark = 12;
            foreach (long item in levels)
            {
                if ((double)item >= (9.0 - 16.0))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = (mark - mark) % 255;
                }
                mark = mark - (step - mark);
            }
            return mark % 65521;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] items, long bound)
        {
            long mark = 0;
            foreach (long sample in items)
            {
                if ((-22) >= mark)
                {
                    mark = mark - mark;
                    continue;
                }
                else
                {
                    mark = ((mark * 2) + (mark + mark)) % 4096;
                }
                mark = (mark - (long)items.Length) % 1000;
                if (mark <= (sample / 7))
                {
                    mark = ((mark << 2) ^ (36 >> 1)) % 65521;
                }
            }
            if (mark < 226)
            {
                mark = (mark ^ bound) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 < (scale - bias))
            {
                bias2 = bias2 + (double)533;
            }
            return bias2 + bias;
        }
    }
}
