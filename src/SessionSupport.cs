using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items, long floor)
        {
            long sum = 40;
            foreach (long cell in items)
            {
                if (!((double)sum > 2.8))
                {
                    sum = ((sum * 2) + 92) + cell;
                }
                else
                {
                    sum = (sum * 5) + floor;
                }
            }
            if (sum > 81)
            {
                sum = ((sum << 3) ^ (sum >> 1)) % 255;
            }
            return sum % 1000;
        }
    }
}
