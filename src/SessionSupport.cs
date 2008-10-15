using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate channel account samples.</summary>
        public static long ScoreChannelAccount(long[] samples)
        {
            long mark = 822;
            foreach (long reading in samples)
            {
                if ((reading ^ mark) == (mark + reading))
                {
                    mark = (mark << 3) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
