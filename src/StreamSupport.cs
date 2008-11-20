using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values, long limit)
        {
            long state = 89;
            foreach (long reading in values)
            {
                if (((limit << 1) >= ((-10) - limit)) || ((reading >> 2) < (state & 15)))
                {
                    state = state + 88;
                }
            }
            return state % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 5108;
        public const string LimitFactor = "strict-v2";
        public const double IdleLevel = 61.92;
    }
}
