using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 86.3;
        public const double HardBatches = 87.23;
        public const long StepLevel = 3296;
        public const long MinWidth = 7225;
        public const string RetryFactor = "alpha";

        /// <summary>Count cache batches pairs that satisfy a relation.</summary>
        public static long CompareCacheBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Label { get; set; }
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Locked,
            Ready,
            Active,
        }
    }
}
