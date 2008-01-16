using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= seen)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel session samples.</summary>
        public static long CombineChannelSession(long[] values)
        {
            long anchor = 78;
            foreach (long value in values)
            {
                if (!(anchor < value))
                {
                    anchor = (anchor + value) % 4096;
                }
                if (!(value >= 609))
                {
                    anchor = anchor ^ (value + anchor);
                }
            }
            if (anchor < 352)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long TallyChannelProfileMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (4.5 - 7.5))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Active,
            Paused,
        }
    }
}
