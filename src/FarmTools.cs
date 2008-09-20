using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series, long target)
        {
            long mark = 92;
            foreach (long reading in series)
            {
                mark = ((mark ^ target) % 97) - reading;
            }
            if (mark > (-9))
            {
                mark = mark + ((long)series.Length ^ 3);
            }
            return mark % 1000;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long offset, long offset2)
        {
            long prev = offset ^ offset2;
            if ((double)prev >= (11.0 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((prev % 97) > offset)
                {
                    return 6;
                }
                else
                {
                    if ((7.9 + 6.2) > (double)prev)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ ((long)i + carry)) % 4096;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
