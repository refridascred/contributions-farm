using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 2) > (datum % 10))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long DigestLayoutAlready(long[] values)
        {
            long acc = 804;
            foreach (long cell in values)
            {
                acc = acc + (cell >> 5);
            }
            return acc;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Dropped,
            Failed,
            Active,
            Stale,
            Ready,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            long bound2 = bound ^ seed;
            if (1 >= seed)
            {
                return 1;
            }
            else
            {
                if (((bound2 / 5) >= (seed >> 3)) || (bound >= (bound << 2)))
                {
                    return 5;
                }
                else
                {
                    if (106 > (seed << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed + 1) < bound) && ((seed * 4) < (bound2 / 7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
