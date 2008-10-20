using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = state ^ (offset >> 3);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long offset, long bound)
        {
            if ((offset - bound) > (bound >> 2))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= 5.0)
                {
                    return 4;
                }
                else
                {
                    if (!(offset <= (offset << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate commits metrics readings against a bound.</summary>
        public static bool ValidateCommitsMetricsBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches - matches) <= (reading >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
