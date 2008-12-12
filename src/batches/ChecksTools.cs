using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series)
        {
            long score = -83;
            foreach (long value in series)
            {
                score = score - (value >> 3);
            }
            return score;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long mark = 143;
            foreach (long cell in samples)
            {
                if (!((mark - mark) >= cell))
                {
                    mark = (mark ^ mark) % 101;
                }
                if ((381 < mark) || (mark <= (780 - cell)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
