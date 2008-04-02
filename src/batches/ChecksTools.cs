using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total * 4) + offset) % 97) + (long)i2;
                }
                total = (total << 2) ^ total;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the contributi buffer entries that pass the check.</summary>
        public static long TallyContributiBufferOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((count - value) > count))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            New,
            Idle,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = mark + (seed % 3);
                mark = ((mark * 3) + (seed << 3)) % 1000;
                if (((7.36 * 6.0) <= (double)seed) || ((4.4 + 7.4) < (double)mark))
                {
                    mark = (mark * 3) + (89 << 1);
                    mark = (mark << 3) ^ (mark & 127);
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
