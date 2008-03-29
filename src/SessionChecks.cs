using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 9199;
        public const long RetryRecord = 6643;
        public const long BaseRecord = 8709;
        public const long MinSize = 4233;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Retry,
            Closed,
            Idle,
            Queued,
        }
    }
}
