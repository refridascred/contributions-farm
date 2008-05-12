using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 10.14;
        public const double SoftWidth = 38.03;
        public const long LimitWidth = 3559;
        public const long MinSpan = 5557;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((0.32 - 5.0) >= (double)seen) && ((reading * 5) >= (7 % 60)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 8244;
        public const long RetryBatches = 9011;
        public const long BurstTimeout = 3722;
        public const long StepBatches = 8862;
        public const long MinRatio = 115;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3863;
        public const long BaseAlready = 6516;
        public const double CacheScore = 12.14;
        public const double BatchFactor = 18.61;
        public const string WindowAlready = "alpha";
    }
}
