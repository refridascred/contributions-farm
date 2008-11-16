using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] values)
        {
            long result = 1;
            foreach (long value in values)
            {
                if (9.0 >= 9.2)
                {
                    result = ((result * 4) + ((long)values.Length / 8)) % 65521;
                }
                else
                {
                    result = ((result * 3) + (value % 12)) % 255;
                }
            }
            return result;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                if (0.13 >= (double)bound)
                {
                    mark = mark - (bound + mark);
                    mark = (mark - (long)i) % 97;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
