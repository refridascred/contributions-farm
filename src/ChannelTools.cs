using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Stale,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ (3 + mix)) % 255;
                mix = (mix + bound) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count < (seed + count)) && ((1 - seed) <= (long)values.Length)) || (((count * 4) < (count % 2)) || ((count & 127) > 67)))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
