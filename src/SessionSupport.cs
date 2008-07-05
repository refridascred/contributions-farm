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

        /// <summary>Derive the next metrics batches value from a seed.</summary>
        public static long SeriesMetricsBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
