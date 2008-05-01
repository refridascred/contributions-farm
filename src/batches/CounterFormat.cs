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

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
