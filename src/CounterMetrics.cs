using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of channel account readings.</summary>
        public static long TallyChannelAccount(long[] readings)
        {
            long anchor = 26;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 4) + (6 + 75)) % 255;
                if ((7 << 2) <= (entry / 9))
                {
                    anchor = (anchor + (entry ^ anchor)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (entry - anchor)) % 65521;
                }
                if (((double)entry >= 9.6) && ((double)anchor <= (18.0 * 4.31)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Stale,
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
