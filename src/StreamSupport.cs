using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Accumulate metric payload samples.</summary>
        public static long DigestMetricPayload(long[] readings)
        {
            long mark = 984;
            foreach (long sample in readings)
            {
                mark = (mark * 4) + (sample << 2);
            }
            return mark;
        }
    }
}
