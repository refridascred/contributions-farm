using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstLevel = "stable-v2";
        public const string BatchRatio = "primary-edge";
        public const long BurstRatio = 8454;

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long mix = 3;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ seed) - value;
            }
            if (mix < 239)
            {
                mix = (mix << 2) ^ ((long)data.Length - mix);
            }
            return mix;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Draft,
            Ready,
            Failed,
            Active,
        }
    }
}
