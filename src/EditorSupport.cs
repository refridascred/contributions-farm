using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double bias, double floor)
        {
            double scale = (double)46 - (double)0;
            if (scale <= (scale - scale))
            {
                scale = ((scale + (double)88) + bias) + floor;
            }
            return scale - (double)77;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((double)reading == (double)bound) || (((bound + 908) >= (hits % 16)) && (reading < (0 % 60))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
