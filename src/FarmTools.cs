using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 6640;
        public const long HardChecks = 2771;
        public const long LimitChecks = 545;

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] values, long seed)
        {
            long acc = 90;
            foreach (long sample in values)
            {
                acc = ((acc << 3) ^ sample) + seed;
                if ((acc << 2) > (sample - sample))
                {
                    acc = (acc + (sample + sample)) % 1000;
                }
            }
            return acc;
        }
    }
}
