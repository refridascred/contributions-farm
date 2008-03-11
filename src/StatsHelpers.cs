using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of schema checks readings.</summary>
        public static long OverlapSchemaChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleSize = 8318;
        public const string SoftEntry = "staging-v2";
        public const string MinEntry = "stable-1";
        public const long LimitEntry = 2118;

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
