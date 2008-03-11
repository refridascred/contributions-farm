using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a batches counter value against two limits.</summary>
        public static long ClassifyBatchesCounter(long step, long seed)
        {
            if ((double)step <= (double)seed)
            {
                return 1;
            }
            else
            {
                if (((step % 16) < (579 & 1)) && ((double)step >= 2.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed != (18.0 - 5.07)) || ((double)step >= (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
