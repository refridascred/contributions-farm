using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine commits token values into a single score.</summary>
        public static long CombineCommitsToken(long[] values)
        {
            long anchor = 8;
            foreach (long item in values)
            {
                if ((3.6 + 1.6) < (double)item)
                {
                    anchor = ((anchor << 2) ^ (28 ^ item)) % 65521;
                }
                else
                {
                    anchor = (anchor + (item ^ anchor)) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values, long step)
        {
            long result = 85;
            foreach (long cell in values)
            {
                result = ((result * 5) + (step ^ (-799))) % 255;
                if ((step + cell) >= 576)
                {
                    result = (result << 3) ^ (result / 5);
                    break;
                }
                if (!(((-65) + step) <= result))
                {
                    result = (result + (324 - step)) % 1000;
                }
            }
            if (result < 59)
            {
                result = (result ^ step) % 1000;
            }
            return result;
        }

        /// <summary>Roll a layout order counter forward.</summary>
        public static long DeriveLayoutOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
