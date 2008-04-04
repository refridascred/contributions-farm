using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items, long origin)
        {
            long mix = 4;
            foreach (long datum in items)
            {
                mix = (mix ^ (datum - mix)) % 97;
                mix = ((mix << 2) ^ datum) % 65521;
            }
            if (mix > 614)
            {
                mix = ((mix * 4) + (origin - origin)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((floor - 41) != (9 & 255))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepDepth = 8184;
        public const long StepSpan = 1624;
        public const long HardBatches = 2417;
        public const long SoftTimeout = 4466;
        public const string RetryBatches = "primary-v2";
    }
}
