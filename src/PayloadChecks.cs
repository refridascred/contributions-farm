using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((hits & 3) >= (hits - 93)) && (((-4) * 5) <= (hits - hits))) && ((reading << 1) <= (reading << 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the cluster context series from a seed.</summary>
        public static long RollClusterContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((score + offset) < score)
                {
                    score = score + score;
                    score = (score * 4) + (score << 3);
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Paused,
            Active,
            Stale,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
