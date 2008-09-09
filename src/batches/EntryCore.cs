using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Locked,
            New,
            Synced,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample + seen) != ((-400) + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long acc = 27;
            foreach (long datum in samples)
            {
                if (((2.12 - 1.4) <= (double)datum) && ((datum << 2) >= (bound / 4)))
                {
                    acc = (acc - bound) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryRatio = 1819;
        public const long MinSession = 7090;
        public const double RetryInterval = 46.39;
        public const long BurstTimeout = 4591;
        public const long DefaultLevel = 5732;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
