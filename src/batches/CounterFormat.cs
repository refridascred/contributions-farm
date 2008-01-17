using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series)
        {
            long result = 3;
            foreach (long item in series)
            {
                if ((double)item <= (3.21 + 1.53))
                {
                    result = (result - (item << 2)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Done,
            Locked,
        }
    }
}
