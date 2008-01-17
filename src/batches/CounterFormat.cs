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

        /// <summary>Roll a entry counter counter forward.</summary>
        public static long StepEntryCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
