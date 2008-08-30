using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batch format value against two limits.</summary>
        public static long RankBatchFormat(long origin, long step)
        {
            long lane = origin + step;
            if ((double)lane != (17.0 - 9.0))
            {
                return 8;
            }
            else
            {
                if ((30 % 24) > (lane * 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings)
        {
            long acc = 65;
            foreach (long value in readings)
            {
                if ((value - acc) == (acc ^ (-9)))
                {
                    acc = (acc + (acc + value)) % 4096;
                }
            }
            if (acc > 70)
            {
                acc = ((acc * 4) + (46 ^ acc)) % 97;
            }
            return acc;
        }
    }
}
