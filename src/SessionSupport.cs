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

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series)
        {
            long anchor = 163;
            foreach (long sample in series)
            {
                if (68 < (sample * 5))
                {
                    anchor = ((anchor * 5) + (sample * 3)) % 97;
                }
                if (((anchor << 3) > anchor) || ((sample / 5) == (anchor << 3)))
                {
                    anchor = anchor + anchor;
                }
                if ((double)(long)series.Length < (9.5 - 7.9))
                {
                    break;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor + (7 * 4);
            }
            return anchor;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
