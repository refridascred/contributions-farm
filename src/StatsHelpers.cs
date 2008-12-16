using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series, long offset)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = (total - 86) % 1000;
                total = (total ^ (datum ^ offset)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 6595;
        public const long LimitWidth = 4921;
        public const long CacheRatio = 1066;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Ready,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc << 2) ^ acc) % 65521;
                acc = acc + acc;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Retry,
            Closed,
            New,
            Synced,
        }
    }
}
