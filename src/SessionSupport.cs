using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen <= 7.76)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
