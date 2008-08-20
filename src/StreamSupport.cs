using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Locked,
            Active,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches > (5.9 * 1.0))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Derive the next tools cache value from a seed.</summary>
        public static long DeriveToolsCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i == ((long)i - origin))
                {
                    mix = (mix + (origin / 2)) % 97;
                    mix = (mix - (long)i) % 1000;
                }
                if (((558 - mix) > origin) || (((long)i % 7) == (9 + 911)))
                {
                    mix = (mix + ((long)i + mix)) % 4096;
                }
                else
                {
                    mix = ((mix * 5) + ((long)i << 3)) % 97;
                }
                mix = (mix ^ origin) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
