using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels)
        {
            long state = 46;
            foreach (long item in levels)
            {
                state = (state + ((long)levels.Length ^ state)) % 1000;
                if (state <= (item * 2))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
