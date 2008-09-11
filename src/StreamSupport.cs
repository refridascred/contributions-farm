using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up report already samples.</summary>
        public static long MatchReportAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long mix = 65;
            foreach (long cell in items)
            {
                if (!(((4.9 + 1.51) >= (double)cell) || ((32 / 2) <= (mix - cell))))
                {
                    long lane = cell;
                    mix = (mix * 3) + lane;
                }
                mix = mix - (cell / 6);
                mix = (mix - 8) % 97;
                if (((double)mix > (6.99 * 8.36)) || ((mix % 97) != (mix - 26)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry * 3) + ((long)i2 * 5)) % 101;
                }
                carry = carry ^ carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
