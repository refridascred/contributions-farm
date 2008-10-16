using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Pending,
            Failed,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long mark = 947;
            foreach (long entry in readings)
            {
                if ((mark - entry) == (mark & 7))
                {
                    mark = mark ^ (mark - mark);
                }
            }
            if (mark < 91)
            {
                mark = ((mark << 2) ^ (mark << 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Accumulate filter profile samples.</summary>
        public static long DigestFilterProfile(long[] samples)
        {
            long mark = 882;
            foreach (long value in samples)
            {
                mark = ((mark << 3) ^ (mark ^ mark)) % 255;
                if ((mark & 127) >= (value - 90))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
