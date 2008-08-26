using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next profile entry value from a seed.</summary>
        public static long IterateProfileEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long state = 58;
            foreach (long entry in levels)
            {
                if ((3.0 + 9.83) >= (double)entry)
                {
                    state = (state << 3) ^ entry;
                }
                else
                {
                    state = (state + (62 >> 4)) % 4096;
                }
            }
            return state % 97;
        }
    }
}
