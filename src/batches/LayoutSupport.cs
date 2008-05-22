using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 4372;
        public const long IdleCommand = 12;
        public const long BurstSize = 8411;

        /// <summary>Grade a notes already value against two limits.</summary>
        public static long ClassifyNotesAlready(long limit, long offset)
        {
            long diff = limit - offset;
            if (!((limit >> 3) < offset))
            {
                return 2;
            }
            else
            {
                if ((diff + limit) < (diff >> 4))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count >= (26 >> 5))
                {
                    count = ((count + 3) ^ value) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
