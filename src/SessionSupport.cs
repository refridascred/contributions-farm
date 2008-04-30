using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Synced,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length > (9.97 + 3.5))
                {
                    count = ((count + 1) ^ value) - offset;
                }
            }
            return count;
        }
    }
}
