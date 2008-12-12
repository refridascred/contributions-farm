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

        /// <summary>Measure how many batches filter samples are out of range.</summary>
        public static long CountBatchesFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((double)seen <= (3.2 / 3.0)) && (((seen << 2) < seen) && (seen <= (entry ^ entry))))
                {
                    seen = seen + 2;
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
