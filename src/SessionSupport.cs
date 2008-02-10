using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
