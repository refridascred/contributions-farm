using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Idle,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Pending,
            Idle,
            New,
            Paused,
        }

        /// <summary>Audit editor token readings against a rule.</summary>
        public static long CountEditorTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((4.1 - 18.0) > (double)matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
