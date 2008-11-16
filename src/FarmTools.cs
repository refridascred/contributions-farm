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

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mix = 851;
            foreach (long value in readings)
            {
                if ((double)67 > (double)mix)
                {
                    mix = (mix * 3) + (4 - value);
                }
            }
            return mix;
        }
    }
}
