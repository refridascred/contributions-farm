using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of editor queue readings.</summary>
        public static long DigestEditorQueue(long[] series)
        {
            long acc = 9;
            foreach (long sample in series)
            {
                if ((acc <= (6 << 1)) || (7.6 > (double)acc))
                {
                    acc = ((acc - (acc & 31)) % 1000) - sample;
                }
            }
            return acc;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - tally) > cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
