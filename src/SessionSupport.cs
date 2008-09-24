using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
