using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Ready,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitSpan = 74.99;
        public const long WindowReport = 2949;
        public const long MinLevel = 8703;
        public const double CacheReport = 59.62;
    }
}
