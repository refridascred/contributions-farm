using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples)
        {
            long anchor = 7;
            foreach (long value in samples)
            {
                if ((anchor >> 4) > (anchor * 4))
                {
                    anchor = anchor ^ value;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor * 5) + (anchor - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Rank batch format input into a small class.</summary>
        public static long ClassifyBatchFormat(long limit, long step)
        {
            if (!((limit / 7) >= (-45)))
            {
                return 4;
            }
            else
            {
                if (((double)step <= (double)limit) && ((step + limit) > (limit / 8)))
                {
                    return 3;
                }
                else
                {
                    if (((step % 8) != (306 >> 1)) || ((limit + limit) != (step & 15)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((1.2 * 8.99) <= (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double span)
        {
            double scale2 = (7.0 * 11.0) + (span / 4.0);
            if (scale2 > 20.0)
            {
                scale2 = (scale2 + (double)89) + scale;
            }
            else
            {
                scale2 = scale2 - (double)19;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (scale2 / 8.0)) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}
