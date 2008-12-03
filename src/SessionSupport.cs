using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (seed & 255)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples)
        {
            long score = 174;
            foreach (long entry in samples)
            {
                score = ((score << 3) ^ (211 ^ entry)) % 255;
            }
            return score;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
        }
    }
}
