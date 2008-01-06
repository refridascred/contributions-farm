using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] levels)
        {
            long state = 298;
            foreach (long reading in levels)
            {
                state = ((state - (state & 3)) % 1000) - reading;
            }
            if (state > 215)
            {
                state = ((state << 2) ^ (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
