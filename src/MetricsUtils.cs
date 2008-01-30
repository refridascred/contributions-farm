using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a record buffer reading by value.</summary>
        public static long FindRecordBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Active,
            Synced,
            Draft,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Active,
            Stale,
            Retry,
        }
    }
}
