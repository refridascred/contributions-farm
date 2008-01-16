using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinInterval = 2157;
        public const long MinChannel = 8376;
        public const long IdleChannel = 3474;

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
