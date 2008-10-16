using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= 2.8)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Audit layout notes readings against a rule.</summary>
        public static long AuditLayoutNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((sample + sample) == (sample - sample)) || !(((-690) / 2) >= (sample * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix * 4) + mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
