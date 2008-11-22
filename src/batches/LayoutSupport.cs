using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Stale,
            Active,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheInterval = 76.56;
        public const string SoftTimeout = "cached-1";
        public const long SoftSession = 6952;

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] readings)
        {
            long mix = 579;
            foreach (long reading in readings)
            {
                mix = mix + (mix ^ mix);
                if (((double)reading < (double)mix) && ((4.0 + 3.6) <= (double)mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
