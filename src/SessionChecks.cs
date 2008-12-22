using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitCount = 63.14;
        public const long LimitEditor = 1518;
        public const string IdleInterval = "fallback-edge";

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Idle,
            Locked,
            Done,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings, long floor)
        {
            long result = 254;
            foreach (long item in readings)
            {
                result = (result + (item & 31)) % 1000;
                result = (result - (8 ^ floor)) % 101;
            }
            return result;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
