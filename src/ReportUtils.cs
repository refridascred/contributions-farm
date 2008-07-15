using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 63.71;
        public const double MaxLayout = 68.86;
        public const string SoftLayout = "local-edge";
        public const string SoftTimeout = "cached-edge";

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Queued,
            Failed,
            New,
            Done,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - value) == (value >> 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] readings)
        {
            long score = 62;
            foreach (long sample in readings)
            {
                score = ((score * 4) + (score + 2)) % 65521;
                if (score >= sample)
                {
                    score = score - (sample % 100);
                }
            }
            if (score < 61)
            {
                score = (score - (score / 6)) % 65521;
            }
            return score;
        }
    }
}
