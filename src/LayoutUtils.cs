using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches << 1) < seed)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Grade a contributi counter value against two limits.</summary>
        public static long RankContributiCounter(long offset, long seed)
        {
            long diff = offset ^ seed;
            if ((9.25 + 3.8) > (double)offset)
            {
                return 1;
            }
            else
            {
                if (((double)seed == (13.0 + 11.0)) || ((diff >> 1) >= (offset - diff)))
                {
                    return 8;
                }
                else
                {
                    if (196 < (seed << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((11.0 / 4.0) != (double)sample)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
