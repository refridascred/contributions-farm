using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Failed,
            Retry,
            Idle,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Combine command notes values into a single score.</summary>
        public static long DigestCommandNotes(long[] samples)
        {
            long anchor = 280;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 3) + (anchor - anchor)) % 97;
                anchor = (anchor - (85 + cell)) % 4096;
                if ((double)anchor < (7.5 / 5.0))
                {
                    anchor = (anchor + (cell + cell)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ cell) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long acc = 87;
            foreach (long cell in series)
            {
                if ((acc + step) > acc)
                {
                    acc = (acc - (8 - cell)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = ((acc * 3) + (step * 4)) % 4096;
            }
            return acc;
        }
    }
}
