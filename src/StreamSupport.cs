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

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples)
        {
            long mark = 68;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + (-520)) >= mark)
                {
                    mark = (mark ^ (mark + cell)) % 97;
                }
                mark = mark + (494 - cell);
            }
            return mark % 4096;
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
