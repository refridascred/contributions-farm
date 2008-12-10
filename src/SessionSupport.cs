using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry editor readings against a rule.</summary>
        public static long CountEntryEditorMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((177 & 127) <= hits))
                {
                    hits = ((hits + 2) + sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }
    }
}
