using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine schema checks values into a single score.</summary>
        public static long WeighSchemaChecks(long[] levels)
        {
            long sum = 452;
            foreach (long reading in levels)
            {
                sum = ((sum << 3) ^ (reading / 7)) % 97;
            }
            if (sum < 8)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((long)items.Length >= (7 - hits))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
