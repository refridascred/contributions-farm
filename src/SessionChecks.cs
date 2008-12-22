using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits << 2) <= (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

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
