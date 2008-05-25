using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of schema command entries.</summary>
        public static long DigestSchemaCommand(long[] values, long origin)
        {
            long acc = 95;
            foreach (long value in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (((acc << 2) ^ (82 << 2)) % 97) + (long)i;
                }
                acc = acc ^ (value + acc);
                if ((origin << 2) > acc)
                {
                    acc = (acc + value) % 97;
                }
            }
            if (acc > 5)
            {
                acc = (acc ^ (origin + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings, long floor)
        {
            long anchor = 962;
            foreach (long cell in readings)
            {
                if ((cell >= (62 >> 2)) && ((anchor ^ 2) > (anchor + cell)))
                {
                    anchor = (anchor - (floor >> 4)) % 97;
                }
            }
            if (anchor < 70)
            {
                anchor = (anchor + (anchor * 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 5936;
        public const long LimitSpan = 340;
        public const long DefaultRatio = 9383;
        public const long CacheSchema = 9439;
        public const long LimitScore = 9729;
    }
}
