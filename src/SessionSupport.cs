using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum + matches) >= (matches % 12)) || (datum >= 8))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = score + ((long)i & 31);
                if (!((long)i <= (5 << 1)))
                {
                    score = score ^ score;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
