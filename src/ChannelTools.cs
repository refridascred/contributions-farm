using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings)
        {
            long acc = 463;
            foreach (long sample in readings)
            {
                if (acc <= (861 + acc))
                {
                    acc = ((acc + (acc << 2)) % 255) + sample;
                }
            }
            if (acc < 28)
            {
                acc = ((acc * 3) + (acc & 1)) % 255;
            }
            return acc % 1000;
        }
    }
}
