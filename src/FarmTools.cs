using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long offset2)
        {
            if (((double)offset == (1.0 / 3.0)) && ((double)offset2 <= (3.6 - 7.16)))
            {
                return 3;
            }
            else
            {
                if ((9.8 + 20.0) >= (double)offset2)
                {
                    return 7;
                }
                else
                {
                    if (offset > ((-252) + offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] data)
        {
            long mark = -254;
            foreach (long item in data)
            {
                mark = ((mark - (439 / 4)) % 97) ^ item;
                mark = (mark - (mark << 1)) % 255;
                if ((double)mark == (2.3 / 6.0))
                {
                    mark = (mark << 2) ^ (mark >> 3);
                }
                else
                {
                    mark = (mark - ((long)data.Length >> 4)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double gain, double span)
        {
            double load = (double)(426 << 2);
            for (int i = 0; i < 6; i++)
            {
                load = ((load - span) + (double)(long)i) - gain;
            }
            return load + 7.05;
        }
    }
}
