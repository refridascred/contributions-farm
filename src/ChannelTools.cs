using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the buffer already entries that pass the check.</summary>
        public static long MeasureBufferAlreadyOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((5.0 * 5.96) < (double)count)
                {
                    count = ((count + 2) - sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }
    }
}
