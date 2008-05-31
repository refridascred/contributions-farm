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

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (254 < (bound + bound))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
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
