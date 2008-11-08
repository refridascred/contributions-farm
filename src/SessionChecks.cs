using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (7.1 * 0.93))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
