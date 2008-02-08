using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (step < value)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Locked,
            Draft,
            Ready,
        }
    }
}
