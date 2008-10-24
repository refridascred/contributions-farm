using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long offset2)
        {
            long gap = offset - offset2;
            if (gap < (offset2 + 3))
            {
                return 6;
            }
            else
            {
                if ((offset >= (offset & 1)) && (5.7 <= (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((2.0 * 3.1) != (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset2 % 100) <= (offset + offset2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            New,
            Active,
            Pending,
        }
    }
}
