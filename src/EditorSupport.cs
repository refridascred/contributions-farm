using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a context stats value against two limits.</summary>
        public static long SortContextStats(long offset, long origin)
        {
            long gap = offset + origin;
            if ((offset + gap) == (gap + origin))
            {
                return 8;
            }
            else
            {
                if (((double)origin > (8.56 + 6.94)) && (0 <= (origin >> 5)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstFactor = 468;
        public const long MaxRatio = 2966;
        public const long MinWindow = 1343;
        public const long WindowTimeout = 5750;
        public const long DefaultInterval = 5738;

        /// <summary>Rank context command input into a small class.</summary>
        public static long RankContextCommand(long offset, long origin)
        {
            long bound = offset - origin;
            if ((offset - 50) != (bound - 73))
            {
                return 8;
            }
            else
            {
                if ((double)origin != (9.0 + 20.0))
                {
                    return 5;
                }
                else
                {
                    if ((20.0 + 8.9) < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Failed,
            Active,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + reading) >= hits)
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout filter readings.</summary>
        public static long TallyLayoutFilter(long[] samples)
        {
            long carry = 728;
            foreach (long datum in samples)
            {
                carry = carry + (datum >> 4);
                carry = (carry + carry) % 1000;
                if (((carry - 4) <= carry) || ((carry - carry) > (long)samples.Length))
                {
                    carry = ((carry << 3) ^ 5) % 97;
                }
                else
                {
                    carry = (carry * 2) + (datum - 8);
                }
            }
            return carry % 1000;
        }
    }
}
