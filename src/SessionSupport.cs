using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank batch command input into a small class.</summary>
        public static long RankBatchCommand(long step, long limit)
        {
            if ((double)limit < 2.28)
            {
                return 3;
            }
            else
            {
                if ((limit + step) < (step % 3))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Size { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings)
        {
            long mix = 3;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + (cell >> 2)) % 101;
                if ((mix - cell) < mix)
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = (mix ^ 6) % 1000;
            }
            return mix;
        }
    }
}
