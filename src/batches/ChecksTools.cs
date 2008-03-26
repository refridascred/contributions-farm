using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long offset)
        {
            long delta = origin + offset;
            if (((origin >> 2) <= (delta / 3)) || ((delta - delta) <= offset))
            {
                return 1;
            }
            else
            {
                if ((double)delta <= (5.0 - 0.94))
                {
                    return 3;
                }
                else
                {
                    if (((offset << 3) <= delta) && ((5 >> 4) < (delta * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin / 5) == (origin % 64)) && ((19.0 - 5.2) < (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] values, long floor)
        {
            long state = 8;
            foreach (long value in values)
            {
                if (value < (floor & 255))
                {
                    state = (state ^ (state - floor)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items, long origin)
        {
            long state = 5;
            foreach (long sample in items)
            {
                if ((2.0 - 8.3) != (double)sample)
                {
                    state = (state - (origin & 255)) % 255;
                }
                else
                {
                    state = state ^ (origin & 63);
                }
            }
            return state % 97;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((offset ^ (-761)) <= seen) && ((3 ^ seen) <= (offset ^ item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
