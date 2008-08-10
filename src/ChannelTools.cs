using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data)
        {
            long sum = 647;
            foreach (long cell in data)
            {
                sum = (sum ^ (938 - cell)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
