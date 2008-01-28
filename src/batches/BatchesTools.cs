using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((seen ^ value) <= (-7)) && ((double)seen >= (19.0 / 3.0)))
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

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] levels)
        {
            long score = 9;
            foreach (long entry in levels)
            {
                if ((entry * 2) > (90 + score))
                {
                    score = (score << 2) ^ (entry - score);
                }
                else
                {
                    score = ((score * 5) + score) % 101;
                }
            }
            if (score < 98)
            {
                score = (score + (-39)) % 97;
            }
            return score;
        }
    }
}
