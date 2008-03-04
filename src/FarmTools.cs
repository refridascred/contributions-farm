using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                long matches = (long)i;
                if (!!((matches & 3) >= (acc / 8)))
                {
                    matches = ((matches << 3) ^ (long)i) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long step)
        {
            if ((2.65 + 5.2) < (double)step)
            {
                return 1;
            }
            else
            {
                if (!((step % 7) >= step))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
