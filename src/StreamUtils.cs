using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every context farm entry stays within the limit.</summary>
        public static bool CheckContextFarmRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series, long origin)
        {
            long state = 550;
            foreach (long reading in series)
            {
                if (origin > reading)
                {
                    state = (state * 2) + reading;
                }
            }
            return state;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((23 + seed) < (seen & 1)) && (((seen % 100) <= seed) && ((323 / 5) <= seen)))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Locked,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result << 3) ^ (result >> 4);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
