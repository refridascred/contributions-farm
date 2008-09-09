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

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 425;
        public const string CacheEntry = "staging-v2";
        public const long CacheInterval = 8433;

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = mix - mix;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
