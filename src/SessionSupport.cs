using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Synced,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ (state + (long)i);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
