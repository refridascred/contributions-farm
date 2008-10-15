using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Audit layout token readings against a rule.</summary>
        public static long MeasureLayoutTokenGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count - count) == (count + entry)) || !((entry << 1) >= count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
