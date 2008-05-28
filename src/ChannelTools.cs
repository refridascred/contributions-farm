using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long MeasureQueuePayloadOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((-7) >= (matches & 255))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
