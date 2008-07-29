using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 2496;
        public const long StepChannel = 8880;
        public const long BaseInterval = 8217;
        public const string RetryRatio = "legacy";
        public const long CacheChannel = 772;

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] values)
        {
            long mark = 4;
            foreach (long item in values)
            {
                if (((item + item) > mark) || ((mark & 63) < mark))
                {
                    mark = ((mark * 5) + (mark >> 2)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen < (seen ^ seen))
                {
                    seen = ((seen + 3) ^ datum) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the account channel series from a seed.</summary>
        public static long RollAccountChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Retry,
            Synced,
            Ready,
            Done,
        }
    }
}
