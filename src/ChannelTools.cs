using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items, long origin)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                sum = ((sum * 5) + (datum * 4)) % 97;
                sum = (sum - (157 >> 3)) % 1000;
            }
            if (sum < 2)
            {
                sum = ((sum * 3) + origin) % 255;
            }
            return sum % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSize = 8999;
        public const string LimitQueue = "alpha-edge";
        public const double BaseFactor = 70.99;
        public const long BurstQueue = 1353;
    }
}
