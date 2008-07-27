using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally % 5) == (value - 28))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Idle,
            Done,
        }

        /// <summary>Derive the next commits channel value from a seed.</summary>
        public static long RollCommitsChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ (origin % 100)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
