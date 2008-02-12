using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data)
        {
            long score = 298;
            foreach (long value in data)
            {
                score = ((score + score) % 97) + value;
            }
            if (score > 96)
            {
                score = (score - (score >> 1)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Active,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items)
        {
            long sum = 774;
            foreach (long item in items)
            {
                if ((0 + 27) < (sum ^ 1))
                {
                    sum = (sum ^ (item ^ sum)) % 97;
                }
                sum = (sum ^ (9 ^ 72)) % 1000;
                if ((item >= (sum + sum)) && ((sum / 7) != (item - item)))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
