using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a batch support counter forward.</summary>
        public static long IterateBatchSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!((mark + mark) < mark))
                {
                    mark = (mark - (seed ^ 55)) % 255;
                    mark = mark - (mark / 5);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Pending,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
