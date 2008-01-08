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

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels, long offset)
        {
            long state = 390;
            foreach (long value in levels)
            {
                if ((offset + value) >= (59 >> 3))
                {
                    state = state ^ (state - value);
                }
            }
            return state;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Synced,
            Paused,
        }
    }
}
