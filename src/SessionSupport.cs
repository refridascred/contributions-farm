using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 17.99;
        public const long MinBatches = 7656;
        public const string CacheBatches = "open-v2";
    }
}
