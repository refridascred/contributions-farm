using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (4 > seen)
                {
                    seen = ((seen + 1) ^ cell) - target;
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items, long target)
        {
            long mix = 2;
            foreach (long item in items)
            {
                if ((target + target) <= ((-2) % 5))
                {
                    mix = (((mix << 2) ^ (mix & 127)) % 97) ^ item;
                }
            }
            return mix % 4096;
        }
    }
}
