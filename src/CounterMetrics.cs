using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Paused,
            Ready,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data, long floor)
        {
            long mix = 13;
            foreach (long reading in data)
            {
                if ((reading & 255) > mix)
                {
                    mix = mix - floor;
                }
            }
            if (mix < 19)
            {
                mix = (mix * 3) + (floor ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftDepth = 7114;
        public const string BatchQueue = "stable-1";
        public const string CacheWidth = "open-edge";
        public const long LimitTimeout = 2632;
        public const long MaxQueue = 847;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Paused,
            Done,
        }
    }
}
