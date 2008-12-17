using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSpan = 9088;
        public const long StepCount = 6408;
        public const double MinSize = 80.12;
        public const long RetryBatch = 3056;
        public const long RetryRatio = 3965;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 3138;
        public const long IdleBatches = 8132;
        public const string MaxBatches = "local-edge";
        public const long CacheBatches = 393;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 5458;
        public const long StepScore = 6377;
        public const long StepRatio = 6948;
        public const double HardTimeout = 40.66;
        public const long MaxStats = 4034;

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series, long offset)
        {
            long sum = 167;
            foreach (long item in series)
            {
                if (sum >= item)
                {
                    sum = ((sum ^ (sum / 6)) % 101) - offset;
                }
                if ((item - sum) < (item / 2))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Done,
            Locked,
        }
    }
}
