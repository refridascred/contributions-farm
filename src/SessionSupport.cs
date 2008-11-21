using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Locked,
            New,
            Pending,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long total = 856;
            foreach (long value in levels)
            {
                if ((value + total) < 153)
                {
                    total = (total * 3) + (value - value);
                }
            }
            return total;
        }
    }
}
