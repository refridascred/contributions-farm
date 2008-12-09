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

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long floor, long floor2)
        {
            long prev = floor + floor2;
            if (((floor2 + floor2) >= (floor ^ floor2)) && ((1.4 + 0.7) <= (double)floor2))
            {
                return 1;
            }
            else
            {
                if (!((floor ^ floor2) != (prev + floor)))
                {
                    return 7;
                }
                else
                {
                    if (((floor2 - floor2) < floor2) && ((double)floor2 <= (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
