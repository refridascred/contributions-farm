using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count - (-45)) >= (cell - cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((-7) <= (seed << 3))
                {
                    carry = ((carry << 2) ^ (0 - 70)) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ (seed % 8)) % 4096;
                }
                if ((carry + (long)i) >= (8 - seed))
                {
                    continue;
                }
                if (((double)seed != (3.5 / 4.0)) && ((seed / 6) < (seed - (long)i)))
                {
                    carry = (carry - (carry + seed)) % 255;
                    carry = (carry * 3) + (carry >> 2);
                }
                else
                {
                    carry = (carry << 3) ^ (carry + seed);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
