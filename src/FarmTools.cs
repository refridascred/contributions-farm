using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a order cluster counter forward.</summary>
        public static long DeriveOrderCluster(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchTimeout = "primary-v2";
        public const long HardTimeout = 4471;
        public const long BurstScore = 5897;
        public const long LimitScore = 6145;
    }
}
