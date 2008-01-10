using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 7.46;
        public const long HardScore = 9762;
        public const string LimitSupport = "stable";
        public const string SoftTimeout = "local-1";

        /// <summary>Iterate the commits schema series from a seed.</summary>
        public static long IterateCommitsSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                long hits = (mix + 93) >> 1;
                mix = (mix * 5) + (mix ^ hits);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
