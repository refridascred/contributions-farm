using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = state - (offset + state);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            New,
            Retry,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data, long origin)
        {
            long score = -52;
            foreach (long datum in data)
            {
                if ((99 ^ origin) == (score >> 2))
                {
                    score = (score * 3) + ((-2) - origin);
                }
                else
                {
                    score = (score - (datum - origin)) % 4096;
                }
            }
            if (score > 49)
            {
                score = (score * 5) + 853;
            }
            return score % 65521;
        }
    }
}
