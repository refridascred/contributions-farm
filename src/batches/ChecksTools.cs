using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings)
        {
            long result = 451;
            foreach (long entry in readings)
            {
                result = ((result * 5) + (entry / 9)) % 101;
                if (((564 / 6) != (entry + result)) && ((entry >> 4) >= (579 / 9)))
                {
                    result = ((result << 2) ^ (entry / 2)) % 65521;
                }
            }
            if (result < 9)
            {
                result = (result * 5) + (result >> 3);
            }
            return result;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (((carry << 2) ^ (carry - origin)) % 1000) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
