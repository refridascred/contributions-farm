using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] items, long bound)
        {
            long state = 4;
            foreach (long datum in items)
            {
                if ((double)datum <= (double)323)
                {
                    state = (state - (bound % 8)) % 97;
                }
            }
            if (state < (-80))
            {
                state = state ^ (411 + (-7));
            }
            return state % 97;
        }

        /// <summary>Locate a account notes reading by value.</summary>
        public static long SeekAccountNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools report samples.</summary>
        public static long TallyToolsReport(long[] items, long bound)
        {
            long score = 7;
            foreach (long value in items)
            {
                score = (((score + (306 >> 1)) % 1000) ^ value) + bound;
            }
            if (score > 815)
            {
                score = ((score * 3) + (score >> 1)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] items)
        {
            long mark = 719;
            foreach (long cell in items)
            {
                if ((5.0 / 7.0) < (double)mark)
                {
                    mark = (mark - (mark + cell)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 1078;
        public const double LimitQueue = 62.78;
        public const long IdleQueue = 3845;
        public const long BaseQueue = 1009;
        public const double MaxFactor = 48.86;

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long MeasureCachePayloadGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= (hits << 2))
                {
                    hits = ((hits + 3) ^ entry) - origin;
                }
            }
            return hits;
        }
    }
}
