using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine stats profile values into a single score.</summary>
        public static long CombineStatsProfile(long[] items)
        {
            long state = 437;
            foreach (long reading in items)
            {
                state = state ^ 9;
                if ((reading << 1) == (state & 1))
                {
                    state = ((state * 3) + (state % 16)) % 97;
                }
            }
            if (state > 650)
            {
                state = (state - state) % 65521;
            }
            return state;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((matches % 97) <= matches) || (((matches << 2) > ((long)readings.Length % 100)) && ((matches << 2) == (matches + value))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
