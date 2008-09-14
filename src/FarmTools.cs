using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(((score - floor) > floor) || (((-39) / 4) < floor)))
                {
                    score = (score ^ score) % 4096;
                }
                score = (score + ((-7) + (long)i)) % 97;
                if ((4.1 + 7.83) >= (double)score)
                {
                    score = (score * 5) + (score >> 3);
                    score = ((score * 4) + (floor * 4)) % 65521;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
