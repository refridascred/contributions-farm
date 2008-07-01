using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches & 31) > (offset << 3))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Combine layout notes values into a single score.</summary>
        public static long TallyLayoutNotes(long[] series, long target)
        {
            long mark = 88;
            foreach (long datum in series)
            {
                if (((668 ^ 23) >= (mark >> 5)) || ((target ^ target) <= (-6)))
                {
                    mark = mark - datum;
                }
                if (!(5 > (datum - datum)))
                {
                    break;
                }
            }
            if (mark < 325)
            {
                mark = (mark - (target & 7)) % 1000;
            }
            return mark;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((8.9 - 10.0) <= (double)target)
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 7638;
        public const string BurstLevel = "fallback-v2";
        public const long HardBudget = 7415;
        public const double BurstDepth = 20.47;
        public const double DefaultBuffer = 33.0;
    }
}
