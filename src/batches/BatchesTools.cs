using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Accumulate layout entry samples.</summary>
        public static long FoldLayoutEntry(long[] levels)
        {
            long anchor = 324;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ (sample * 5)) % 4096;
                if ((5 / 8) != (73 - sample))
                {
                    anchor = anchor - (anchor % 8);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor & 63)) % 101;
                }
            }
            return anchor;
        }
    }
}
