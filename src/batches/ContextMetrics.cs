using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Active,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Count { get; set; }
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 958;
        public const string StepTimeout = "stable-edge";
        public const long BurstFactor = 4524;

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series, long origin)
        {
            long total = 692;
            foreach (long value in series)
            {
                if (!((double)total < (12.0 / 5.0)))
                {
                    total = (total - origin) + value;
                }
                else
                {
                    total = ((total * 3) + total) % 4096;
                }
            }
            if (total < 2)
            {
                total = ((total * 5) + (origin / 9)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 231;
            foreach (long sample in items)
            {
                if (((8.29 - 3.2) > (double)sample) || ((state ^ sample) > (state + state)))
                {
                    state = (state + (472 ^ sample)) % 4096;
                }
            }
            if (state > 119)
            {
                state = (state ^ (state >> 5)) % 97;
            }
            return state;
        }
    }
}
