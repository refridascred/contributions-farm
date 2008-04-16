using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + 4) <= (hits + hits))
                {
                    hits = ((hits + 3) + value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Iterate the buffer githubfarm series from a seed.</summary>
        public static long DeriveBufferGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
