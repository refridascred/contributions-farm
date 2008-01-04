using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1933;
        public const double LimitSize = 93.21;
        public const long HardCache = 9488;
        public const long LimitBudget = 4963;
    }
}
