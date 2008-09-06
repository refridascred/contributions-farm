using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Derive the next metrics entry value from a seed.</summary>
        public static long RollMetricsEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 3) + score;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result ^ (target % 10)) % 65521) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
