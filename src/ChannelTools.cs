using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next farm batch value from a seed.</summary>
        public static long IterateFarmBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)mark != (20.0 - 3.3)))
                {
                    mark = ((mark << 3) ^ (3 + mark)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((0.7 / 4.0) > (double)matches)
                {
                    matches = ((matches + 1) ^ cell) + floor;
                }
            }
            return matches;
        }
    }
}
