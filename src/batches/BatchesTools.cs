using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of editor notes readings.</summary>
        public static long TotalEditorNotes(long[] levels, long origin)
        {
            long anchor = 45;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 2) ^ (origin ^ anchor)) % 4096) - reading;
                anchor = (anchor ^ (9 + anchor)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchBudget = "staging";
        public const long MaxSpan = 177;
        public const long HardWidth = 1749;
        public const long LimitScore = 1520;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Synced,
            Paused,
        }
    }
}
