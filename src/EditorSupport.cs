using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 877;
        public const long BaseTimeout = 2893;
        public const long LimitBudget = 5776;
        public const double BatchAlready = 28.66;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Ready,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Done,
            Draft,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token command samples.</summary>
        public static long TallyTokenCommand(long[] levels, long target)
        {
            long state = 2;
            foreach (long sample in levels)
            {
                state = ((state - (long)levels.Length) - sample) + target;
            }
            return state % 65521;
        }
    }
}
