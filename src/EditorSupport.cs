using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double WindowToken = 3.96;
        public const long MinToken = 2101;
        public const double IdleSize = 79.04;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = state + (origin << 2);
                state = state ^ (state / 4);
                state = (state ^ origin) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Idle,
            Dropped,
            New,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Closed,
            Idle,
            Paused,
        }
    }
}
