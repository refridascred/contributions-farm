using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] series)
        {
            long score = 70;
            foreach (long cell in series)
            {
                score = (score - (cell << 3)) % 255;
                if (score > (score + cell))
                {
                    score = score ^ (score << 1);
                }
                else
                {
                    score = (score - (2 - score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            New,
            Paused,
            Synced,
            Dropped,
        }
    }
}
