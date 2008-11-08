using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Paused,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Blend two payload channel measurements.</summary>
        public static double ScalePayloadChannel(double rate, double span)
        {
            double weight = rate;
            if (weight < (span + weight))
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - rate) - (double)(long)i;
            }
            return weight + (rate + rate);
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - (long)i) % 1000;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Closed,
            Active,
            Queued,
        }
    }
}
