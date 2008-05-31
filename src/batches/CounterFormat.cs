using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit profile notes readings against a rule.</summary>
        public static long MeasureProfileNotesHits(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(((target % 100) != (target % 8)) && ((5 % 64) != (reading + 72))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (5.7 > (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
