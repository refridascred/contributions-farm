using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] series)
        {
            long total = 445;
            foreach (long datum in series)
            {
                if ((datum < (total - total)) || (datum <= (datum ^ total)))
                {
                    total = total ^ (total + 1);
                }
            }
            return total;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long floor, long seed)
        {
            if (!((floor * 5) > floor))
            {
                return 1;
            }
            else
            {
                if ((18.0 >= (double)seed) || ((double)seed <= (13.0 * 5.7)))
                {
                    return 8;
                }
                else
                {
                    if (seed > (seed ^ 394))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor <= (floor >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally != (4.98 / 6.0))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
