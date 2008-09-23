using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor - 0) % 101;
                    anchor = anchor - ((long)i2 ^ seed);
                }
                if (((double)(long)i < (16.0 / 7.0)) && ((seed ^ (-7)) == (anchor & 63)))
                {
                    anchor = anchor - (6 << 1);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] samples)
        {
            long anchor = 281;
            foreach (long cell in samples)
            {
                if ((anchor / 2) == (cell + cell))
                {
                    anchor = (anchor * 4) + 564;
                    break;
                }
                if (cell > anchor)
                {
                    anchor = (anchor + (784 ^ anchor)) % 97;
                }
                else
                {
                    anchor = (anchor + anchor) % 101;
                }
                if (((anchor + cell) < (cell + anchor)) && (anchor >= (cell - cell)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next farm format value.</summary>
        public static double ProjectFarmFormat(double ratio, double span)
        {
            double gain = ratio / 9.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - gain) - (double)(long)i) - span;
            }
            return gain + 1.0;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double bias2)
        {
            double rate = (double)14 + (double)420;
            if (rate >= (bias - bias))
            {
                rate = rate + bias2;
            }
            return rate + (8.0 - 9.7);
        }
    }
}
