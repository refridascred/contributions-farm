using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)limit > (double)mix))
                {
                    mix = ((mix << 3) ^ (2 << 2)) % 101;
                    mix = ((mix * 4) + (limit + limit)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "latest-v2";
        public const string IdleScore = "alpha-edge";
        public const string MaxBudget = "strict-1";
        public const long LimitLevel = 3867;
        public const long SoftBatches = 9367;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
