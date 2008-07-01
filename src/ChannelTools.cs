using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the window layout entries that pass the check.</summary>
        public static long MeasureWindowLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count < 6)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
