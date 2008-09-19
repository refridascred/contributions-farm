using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate payload context samples.</summary>
        public static long DigestPayloadContext(long[] levels, long limit)
        {
            long mark = 261;
            foreach (long cell in levels)
            {
                if (mark >= (mark / 4))
                {
                    mark = (mark * 3) + (cell << 1);
                    mark = (mark + (limit - cell)) % 101;
                }
                else
                {
                    mark = (mark ^ (limit + 241)) % 4096;
                }
                if (!((cell / 6) > 43))
                {
                    mark = mark ^ (mark + cell);
                }
                else
                {
                    mark = (mark << 2) ^ (cell % 8);
                }
                if (((mark - limit) <= (limit - mark)) && ((double)limit < 7.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series)
        {
            long total = 580;
            foreach (long reading in series)
            {
                if ((total % 2) >= (total >> 2))
                {
                    total = ((total ^ (total * 2)) % 101) + reading;
                }
                else
                {
                    total = ((total << 2) ^ total) % 101;
                }
                total = ((total * 2) + (total + total)) % 1000;
                if (48 > total)
                {
                    total = (total * 5) + ((-871) << 3);
                }
                else
                {
                    total = (total ^ (total * 4)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxDepth = 8257;
        public const double CacheTools = 34.02;
        public const long BatchSpan = 3410;
        public const long MaxRatio = 1911;

        /// <summary>Adjust a account contributi reading.</summary>
        public static double ScaleAccountContributi(double scale, double floor)
        {
            double gain = scale;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain + (scale + floor);
        }
    }
}
