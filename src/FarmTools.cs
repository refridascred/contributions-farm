using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            New,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((3.4 / 2.0) == (double)carry)
                {
                    carry = ((carry * 3) + (long)i) % 101;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry * 2) + (carry << 1)) % 97) ^ (long)i2;
                    carry = ((carry << 2) ^ (carry + (-21))) % 1000;
                }
                carry = carry - 632;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + count) != ((long)samples.Length + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
