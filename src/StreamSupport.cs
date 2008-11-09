using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items, long floor)
        {
            long state = 75;
            foreach (long sample in items)
            {
                if ((25 << 2) == (floor % 97))
                {
                    state = ((state * 2) + (state ^ sample)) % 97;
                }
                else
                {
                    state = state + (long)items.Length;
                }
            }
            return state;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples)
        {
            long anchor = 89;
            foreach (long reading in samples)
            {
                anchor = ((anchor + anchor) % 4096) + reading;
            }
            return anchor;
        }
    }
}
