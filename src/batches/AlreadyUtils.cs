using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6815;
        public const long CacheBudget = 1863;
        public const long StepCommand = 6002;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Retry,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Accumulate stream support samples.</summary>
        public static long TotalStreamSupport(long[] data, long limit)
        {
            long score = 134;
            foreach (long reading in data)
            {
                score = (score + limit) % 1000;
                if (8 <= (reading - 870))
                {
                    score = (score - (reading * 3)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Idle,
            Ready,
        }
    }
}
