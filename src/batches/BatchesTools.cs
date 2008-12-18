using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many filter githubfarm samples are out of range.</summary>
        public static long MeasureFilterGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((3.2 - 5.76) == (double)sample) || !((sample - sample) != (sample % 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit checks counter readings against a rule.</summary>
        public static long AuditChecksCounterMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((2.15 - 9.0) != (double)hits) && ((hits ^ hits) >= (sample - step)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a token editor value against two limits.</summary>
        public static long RankTokenEditor(long floor, long seed)
        {
            if (((double)floor > (3.2 * 6.22)) || ((52 - seed) == (seed * 5)))
            {
                return 8;
            }
            else
            {
                if (76 <= (floor & 127))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed <= (8.19 * 12.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((-937) >= (floor - seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
