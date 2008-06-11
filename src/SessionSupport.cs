using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data, long origin)
        {
            long mark = -9;
            foreach (long item in data)
            {
                if ((209 <= origin) && ((mark % 2) > item))
                {
                    mark = (mark + (item << 1)) % 1000;
                }
                else
                {
                    mark = (mark ^ (mark - origin)) % 255;
                }
                mark = (mark << 2) ^ (mark + item);
                if ((mark - item) > item)
                {
                    mark = ((mark << 3) ^ (mark + origin)) % 65521;
                }
            }
            return mark;
        }
    }
}
