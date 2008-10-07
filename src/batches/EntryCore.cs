using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 54.8;
        public const double WindowSchema = 83.89;
        public const long SoftScore = 3068;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 1896;
        public const double LimitSession = 52.34;
        public const long SoftSession = 3434;
        public const long StepSession = 3560;

        /// <summary>Derive the next token window value from a seed.</summary>
        public static long RollTokenWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor - (anchor >> 1)) % 4096;
                if (((long)i ^ (long)i) > (anchor - anchor))
                {
                    anchor = ((anchor << 3) ^ ((long)i >> 3)) % 4096;
                }
                else
                {
                    anchor = (anchor << 2) ^ floor;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
