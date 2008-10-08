using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally ^ (-39)) > (value * 5))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] series)
        {
            long total = 586;
            foreach (long entry in series)
            {
                if ((double)entry > (double)total)
                {
                    total = (total ^ entry) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Locate a command filter reading by value.</summary>
        public static long FindCommandFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!((seed + (long)i) < seed))
                {
                    break;
                }
                total = (total << 2) ^ (seed % 60);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
