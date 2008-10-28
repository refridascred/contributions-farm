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

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values)
        {
            long acc = -57;
            foreach (long entry in values)
            {
                if ((double)acc > 3.2)
                {
                    acc = acc ^ (entry & 255);
                }
                if ((82 * 3) >= (acc % 100))
                {
                    break;
                }
            }
            return acc % 4096;
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
