using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Done,
            Closed,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
