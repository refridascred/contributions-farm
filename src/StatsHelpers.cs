using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 5) + (6 % 100)) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if (anchor >= (limit - anchor))
                {
                    anchor = (anchor * 5) + (anchor * 5);
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
                if (((double)38 >= (double)limit) && ((limit >> 4) > anchor))
                {
                    anchor = ((anchor * 5) + (limit - (long)i)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((value > (matches + matches)) || ((double)value >= (5.2 / 9.0))) || (matches <= (699 % 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long CountCommandNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (277 >= (matches - matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
