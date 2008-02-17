using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit contributi counter readings against a rule.</summary>
        public static long CountContributiCounterGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((cell >> 3) > (cell & 3)) || ((cell ^ cell) <= (cell - seen)))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Pending,
            Locked,
            Paused,
            Done,
            Dropped,
        }
    }
}
