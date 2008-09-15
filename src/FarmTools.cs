using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series)
        {
            long sum = -848;
            foreach (long entry in series)
            {
                sum = (sum << 2) ^ (sum + entry);
                if (((622 - sum) > 483) && ((sum % 8) >= entry))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long step)
        {
            if (floor <= (floor % 97))
            {
                return 2;
            }
            else
            {
                if (((5.34 + 13.0) >= (double)step) && ((step % 97) == (1 - 997)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (floor < 910)
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
