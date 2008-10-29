using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 6835;
        public const long LimitScore = 1385;
        public const double SoftReport = 66.58;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowFactor = 5398;
        public const long MinBatch = 4056;
        public const string WindowBatch = "stable";

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long score = 276;
            foreach (long cell in readings)
            {
                if (!(((score ^ score) == (cell >> 2)) && ((double)score == (double)0)))
                {
                    score = (score << 2) ^ (score << 3);
                }
                if (!(score >= (cell / 3)))
                {
                    score = ((score << 3) ^ score) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
