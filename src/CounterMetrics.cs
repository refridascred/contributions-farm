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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine already schema values into a single score.</summary>
        public static long WeighAlreadySchema(long[] items, long offset)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                if (((double)sum < (double)offset) || ((entry & 15) > ((long)items.Length - sum)))
                {
                    sum = (sum ^ offset) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Closed,
            Draft,
            Idle,
            Locked,
        }
    }
}
