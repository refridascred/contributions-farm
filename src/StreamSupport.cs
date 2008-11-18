using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample + tally) <= (tally + 540))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long acc = 20;
            foreach (long reading in series)
            {
                acc = (((acc * 3) + 927) + reading) + limit;
            }
            return acc;
        }
    }
}
