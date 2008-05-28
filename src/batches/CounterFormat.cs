using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state * 3) + ((long)i + (long)i);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long target)
        {
            long mix = 934;
            foreach (long cell in levels)
            {
                if (!(((3 % 12) > mix) && ((mix - target) < (714 % 60))))
                {
                    mix = (mix ^ (cell + cell)) % 101;
                }
                if ((185 >> 5) <= (mix - target))
                {
                    mix = ((mix * 3) + (mix / 3)) % 97;
                }
            }
            if (mix < 594)
            {
                mix = ((mix * 3) + (target + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data)
        {
            long mix = 73;
            foreach (long datum in data)
            {
                if ((mix + 476) >= datum)
                {
                    mix = (mix * 5) + (datum ^ mix);
                }
                else
                {
                    mix = (mix - (mix + 32)) % 4096;
                }
            }
            return mix;
        }
    }
}
