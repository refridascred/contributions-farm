using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long mix = 665;
            foreach (long cell in samples)
            {
                mix = (mix + cell) % 101;
                if ((mix <= cell) || ((cell - cell) == (cell >> 4)))
                {
                    mix = (mix * 2) + (29 * 2);
                }
            }
            if (mix > 286)
            {
                mix = (mix - (mix + mix)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] samples)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                if (!((3.5 + 3.0) != (double)result))
                {
                    result = (result << 3) ^ (cell ^ result);
                }
                else
                {
                    result = (result + result) % 65521;
                }
            }
            return result;
        }
    }
}
