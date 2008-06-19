using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits / 2) > 6)
                {
                    hits = ((hits + 1) + value) - bound;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long target)
        {
            long edge = floor ^ target;
            if (edge < (edge << 2))
            {
                return 0;
            }
            else
            {
                if ((edge - edge) >= target)
                {
                    return 3;
                }
                else
                {
                    if (floor <= (floor << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((1.2 + 4.5) < (double)edge) && ((target % 8) >= edge))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long state = 69;
            foreach (long sample in values)
            {
                state = (state ^ (state - sample)) % 1000;
            }
            if (state < 708)
            {
                state = (state + (state & 31)) % 255;
            }
            return state;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)offset != (14.0 - 8.32)) || !(76 < (offset + offset)))
                {
                    seen = (seen + 2) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
