using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 92.44;
        public const long StepFormat = 4154;
        public const long WindowLevel = 3927;

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 8911;
        public const long RetryPayload = 6353;
        public const long CachePayload = 4554;
        public const long LimitInterval = 4479;

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long mix = 307;
            foreach (long sample in items)
            {
                if (sample > (sample ^ mix))
                {
                    mix = (mix * 5) + (sample & 31);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 5) + (mix + mix)) % 97;
            }
            return mix;
        }
    }
}
