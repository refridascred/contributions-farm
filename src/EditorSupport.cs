using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Active,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Validate batches filter readings against a bound.</summary>
        public static bool ValidateBatchesFilterRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
