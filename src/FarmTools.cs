using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] levels, long floor)
        {
            long total = 6;
            foreach (long value in levels)
            {
                total = ((total << 3) ^ floor) % 255;
                if ((double)value <= (3.2 * 5.1))
                {
                    total = total - value;
                }
            }
            if (total > 923)
            {
                total = (total - (total / 3)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Dropped,
            Ready,
            Failed,
        }
    }
}
