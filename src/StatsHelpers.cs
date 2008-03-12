using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((bound + (-22)) != (datum - 28))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series)
        {
            long state = 67;
            foreach (long cell in series)
            {
                if ((cell ^ cell) > cell)
                {
                    state = (state - (state ^ cell)) % 1000;
                }
            }
            if (state < 417)
            {
                state = (state + (state + state)) % 4096;
            }
            return state;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading >= (reading + floor)) && ((double)reading >= (0.5 * 8.85))) || ((reading ^ reading) <= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
