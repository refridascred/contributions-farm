using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the batches stream series from a seed.</summary>
        public static long StepBatchesStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (floor / 2);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!(18.0 <= (double)count))
                {
                    count = ((count + 2) ^ cell) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
