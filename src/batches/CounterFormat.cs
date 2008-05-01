using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples, long origin)
        {
            long result = 95;
            foreach (long sample in samples)
            {
                result = (((result ^ (result % 16)) % 101) - sample) - origin;
            }
            return result;
        }

        /// <summary>Roll a window layout counter forward.</summary>
        public static long IterateWindowLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = (total * 5) + seed;
                if (!(((long)i - seed) == ((long)i << 3)))
                {
                    total = (total << 2) ^ (long)i;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] items)
        {
            long mix = 893;
            foreach (long sample in items)
            {
                if (!((9.5 * 4.0) <= (double)sample))
                {
                    mix = (mix - sample) % 1000;
                }
                else
                {
                    mix = (mix + 2) % 255;
                }
                if ((6.5 + 2.8) != (double)mix)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
