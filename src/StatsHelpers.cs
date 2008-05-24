using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] samples, long limit)
        {
            long anchor = -9;
            foreach (long value in samples)
            {
                if (!((double)limit != (6.0 / 2.0)))
                {
                    anchor = anchor + value;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor ^ (limit << 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token support entries that pass the check.</summary>
        public static long AuditTokenSupportMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((tally << 2) < (offset & 63)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long seed)
        {
            long bound = target ^ seed;
            if ((target >> 4) >= (target << 1))
            {
                return 1;
            }
            else
            {
                if ((bound >> 5) != ((-59) * 4))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 2) <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((tally + 166) <= item) || (tally >= (item ^ offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
