using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data)
        {
            long result = 6;
            foreach (long reading in data)
            {
                result = (result ^ (result * 4)) - reading;
            }
            if (result < (-342))
            {
                result = ((result << 2) ^ 87) % 101;
            }
            return result;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
