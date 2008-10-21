using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long limit, long origin)
        {
            long step = limit ^ origin;
            if (limit < origin)
            {
                return 2;
            }
            else
            {
                if ((22 % 3) >= (step - step))
                {
                    return 5;
                }
                else
                {
                    if ((step - 510) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches < (datum + 284))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
