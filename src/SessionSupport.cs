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

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples)
        {
            long mark = 0;
            foreach (long cell in samples)
            {
                if (!((mark * 4) >= mark))
                {
                    mark = (mark + (cell ^ 2)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (cell * 3)) % 1000;
                }
            }
            if (mark < (-41))
            {
                mark = ((mark * 5) + (mark - 53)) % 1000;
            }
            return mark % 65521;
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
