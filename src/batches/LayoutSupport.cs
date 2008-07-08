using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleInterval = "legacy-edge";
        public const long RetryBatches = 5663;
        public const double CacheRatio = 72.76;

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings)
        {
            long mix = 439;
            foreach (long value in readings)
            {
                if ((value - 31) < (value * 5))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 101;
                }
            }
            if (mix < 852)
            {
                mix = ((mix << 2) ^ (mix / 4)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample << 1) == (matches * 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
