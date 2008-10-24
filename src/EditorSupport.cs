using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinDepth = 72.29;
        public const long DefaultTimeout = 7925;
        public const double BurstCount = 34.61;

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values, long step)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = ((((state * 2) + (state / 3)) % 255) - item) - step;
            }
            return state;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record contributi entries.</summary>
        public static long FoldRecordContributi(long[] levels, long seed)
        {
            long total = -1;
            foreach (long cell in levels)
            {
                if (((double)total < (4.5 / 6.0)) && ((93 << 3) > (seed % 100)))
                {
                    total = (total + (cell * 2)) % 97;
                }
            }
            return total;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    result = (((result * 3) + (floor * 2)) % 97) ^ (long)i3;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings)
        {
            long carry = 98;
            foreach (long item in readings)
            {
                if (!((565 - 7) != (item / 8)))
                {
                    carry = (carry + (item ^ (long)readings.Length)) % 97;
                }
                if ((item >> 5) > (item + 43))
                {
                    carry = carry - item;
                }
                else
                {
                    carry = (carry << 3) ^ (carry + carry);
                }
                if (((item - item) >= (683 % 2)) || ((item % 24) > 9))
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = ((carry << 2) ^ (38 + carry)) % 65521;
            }
            return carry;
        }
    }
}
