using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] data)
        {
            long anchor = 79;
            foreach (long item in data)
            {
                anchor = ((anchor << 3) ^ (item >> 1)) % 97;
                anchor = anchor - (item * 3);
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 4392;
        public const long MinAlready = 5553;
        public const double DefaultAlready = 90.06;
        public const long BatchSize = 6215;
        public const string SoftWidth = "staging-1";

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
