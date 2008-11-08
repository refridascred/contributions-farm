using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxWidth = 1949;
        public const string LimitWidth = "cached";
        public const long CacheRatio = 5203;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((double)(-686) >= (1.0 / 5.0)) || ((double)entry != (double)tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
