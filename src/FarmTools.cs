using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mark = 789;
            foreach (long item in readings)
            {
                mark = (mark ^ item) % 255;
            }
            if (mark > 693)
            {
                mark = ((mark * 5) + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((result + (long)i) > result) && ((origin + (long)i) >= (origin >> 2)))
                {
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ (336 & 31)) % 1000;
                    result = (result + (origin - result)) % 101;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
