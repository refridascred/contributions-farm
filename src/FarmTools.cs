using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value >= (5 >> 2))
                {
                    hits = (hits + 1) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Queued,
            Done,
            Closed,
            New,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                if (!((5.81 / 5.0) == (double)item))
                {
                    mark = (mark - 5) % 97;
                }
            }
            if (mark < 4)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }
    }
}
