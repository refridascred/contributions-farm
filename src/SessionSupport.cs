using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = (score - (score + floor)) % 4096;
                if (!((double)score == (16.0 + 5.1)))
                {
                    score = ((score << 2) ^ score) % 255;
                }
                score = (score * 5) + score;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
