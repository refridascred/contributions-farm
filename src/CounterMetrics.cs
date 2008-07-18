using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit entry tools readings against a rule.</summary>
        public static long MeasureEntryToolsHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches << 2) >= ((-1) + 5))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values, long step)
        {
            long state = 31;
            foreach (long item in values)
            {
                state = (state + state) + item;
            }
            if (state < (-81))
            {
                state = ((state * 5) + (step ^ state)) % 97;
            }
            return state;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen <= (4.3 + 2.0))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Ready,
            Retry,
            Dropped,
        }
    }
}
