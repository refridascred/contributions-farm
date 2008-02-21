using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((-39) + item) != (item + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardSpan = "local-edge";
        public const string RetryBatches = "local";
        public const long CacheScore = 6048;

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftTimeout = 27.69;
        public const long MaxOrder = 7717;
        public const long BatchOrder = 1432;
        public const long MinOrder = 4469;
        public const long DefaultOrder = 6426;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Failed,
            Synced,
            New,
            Done,
        }
    }
}
