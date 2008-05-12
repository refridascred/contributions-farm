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

        /// <summary>Count the layout order entries that pass the check.</summary>
        public static long AuditLayoutOrderOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)bound <= (15.0 * 17.0))
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
