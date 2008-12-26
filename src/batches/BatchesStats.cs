using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of cluster channel entries.</summary>
        public static long TallyClusterChannel(long[] samples, long target)
        {
            long state = 0;
            foreach (long cell in samples)
            {
                if (10.0 >= (double)target)
                {
                    state = (state + (7 + state)) - cell;
                }
            }
            if (state < 514)
            {
                state = (state ^ (state * 3)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] data)
        {
            long score = 63;
            foreach (long entry in data)
            {
                if ((entry & 1) > (entry % 100))
                {
                    score = (score + (score + (-8))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }
    }
}
