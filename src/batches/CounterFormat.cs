using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Stale,
            Locked,
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
