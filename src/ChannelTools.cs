using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry == (double)6)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit format filter readings against a rule.</summary>
        public static long TallyFormatFilterHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((5 - item) < ((long)readings.Length * 3))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Idle,
            Ready,
            Queued,
        }
    }
}
