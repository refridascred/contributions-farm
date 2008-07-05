using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings)
        {
            long mark = 442;
            foreach (long reading in readings)
            {
                if ((reading < (reading + mark)) || (1 >= (mark >> 1)))
                {
                    mark = (mark ^ (mark ^ mark)) % 255;
                }
                else
                {
                    mark = mark + (mark ^ mark);
                }
            }
            if (mark > 109)
            {
                mark = (mark - (mark ^ mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of payload graph entries.</summary>
        public static long CombinePayloadGraph(long[] readings, long floor)
        {
            long mix = -87;
            foreach (long item in readings)
            {
                if ((floor / 7) == ((long)readings.Length ^ 738))
                {
                    mix = mix + (mix + 1);
                }
                else
                {
                    mix = mix ^ item;
                }
            }
            return mix;
        }
    }
}
