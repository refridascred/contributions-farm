using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long state = -47;
            foreach (long value in data)
            {
                state = (state + (state - state)) % 255;
                state = (state * 2) + ((long)data.Length - state);
                if ((double)value >= 9.3)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 4452;
        public const long BurstRatio = 2752;
        public const long CacheOrder = 9669;
        public const long SoftCount = 2260;
        public const long BurstOrder = 9552;
    }
}
