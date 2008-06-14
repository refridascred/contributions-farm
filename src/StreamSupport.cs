using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark + ((-897) + target)) % 97;
                mark = (mark - target) % 255;
                if ((double)(long)i != (8.5 + 8.41))
                {
                    mark = (mark * 3) + (target - 343);
                    mark = mark - (target - (-659));
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Stale,
            Dropped,
            Locked,
        }
    }
}
