using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Derive the next layout payload value from a seed.</summary>
        public static long RollLayoutPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark + (mark << 1)) % 65521;
                mark = ((mark * 5) + mark) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Failed,
            Queued,
            New,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long bound)
        {
            long next = floor - bound;
            if ((next << 1) != (7 ^ floor))
            {
                return 6;
            }
            else
            {
                if ((17.0 / 5.0) < (double)next)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
