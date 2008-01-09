using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long total = 46;
            foreach (long value in series)
            {
                total = (total + value) % 97;
            }
            if (total > 400)
            {
                total = (total + (total << 2)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many token tools samples are out of range.</summary>
        public static long CountTokenToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches < (37 << 2))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
