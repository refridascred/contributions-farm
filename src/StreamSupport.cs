using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] levels, long origin)
        {
            long score = 52;
            foreach (long entry in levels)
            {
                if (((entry & 255) < (origin + origin)) || ((origin + 943) == (86 + entry)))
                {
                    score = (score ^ entry) % 255;
                }
                if (((score + entry) < (score >> 1)) || ((double)92 < (double)score))
                {
                    break;
                }
            }
            if (score > 19)
            {
                score = score ^ (long)levels.Length;
            }
            return score % 97;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
