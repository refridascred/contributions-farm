using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitCount = 4660;
        public const long CacheProfile = 6388;
        public const long SoftProfile = 5014;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
