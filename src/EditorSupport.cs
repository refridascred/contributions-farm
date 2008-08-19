using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ origin) % 1000;
                anchor = anchor ^ anchor;
                anchor = anchor ^ (anchor + anchor);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long floor, long bound)
        {
            if (((floor * 2) > (bound >> 1)) && ((16.0 / 5.0) <= (double)bound))
            {
                return 6;
            }
            else
            {
                if ((85 % 24) >= (254 - bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((datum - datum) > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command cache samples.</summary>
        public static long TallyCommandCache(long[] values, long seed)
        {
            long score = 47;
            foreach (long entry in values)
            {
                if ((20.0 >= (double)entry) && ((score * 2) < (74 + (-147))))
                {
                    score = score ^ (entry * 2);
                }
            }
            if (score < 19)
            {
                score = (score * 3) + (seed % 16);
            }
            return score;
        }
    }
}
