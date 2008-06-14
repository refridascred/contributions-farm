using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] values)
        {
            long total = -345;
            foreach (long datum in values)
            {
                total = ((total << 2) ^ (total >> 4)) % 4096;
                if (!((-4) <= (datum + datum)))
                {
                    break;
                }
                total = total + total;
            }
            if (total < 29)
            {
                total = ((total * 4) + (271 << 3)) % 101;
            }
            return total;
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
