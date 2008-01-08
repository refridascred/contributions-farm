using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next checks schema value from a seed.</summary>
        public static long DeriveChecksSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ (mark % 64)) % 255;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a filter payload pair into a bucket.</summary>
        public static long GradeFilterPayload(long origin, long seed)
        {
            if ((origin * 3) == (origin + origin))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) > (50 * 5))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the order cache series from a seed.</summary>
        public static long RollOrderCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
