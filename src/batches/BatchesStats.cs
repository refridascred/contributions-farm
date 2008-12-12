using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits >= (long)readings.Length) || ((993 - hits) < hits))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = (state ^ (866 - state)) % 97;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mark = 497;
            foreach (long reading in values)
            {
                if (!(mark > (reading - mark)))
                {
                    mark = (mark * 4) + (mark + reading);
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }
    }
}
