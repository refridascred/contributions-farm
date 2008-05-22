using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batches payload entries that pass the check.</summary>
        public static long AuditBatchesPayloadMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (double)60)
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)step > (double)datum)
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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((bound >> 2) >= (bound * 5))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
