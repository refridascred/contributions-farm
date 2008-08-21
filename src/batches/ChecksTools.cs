using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value >= (value << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Draft,
            Retry,
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings)
        {
            long acc = 33;
            foreach (long value in readings)
            {
                if ((value - value) == (value + acc))
                {
                    acc = (acc + (acc % 2)) % 1000;
                    acc = ((acc * 5) + (acc & 7)) % 65521;
                }
                if ((acc - 86) >= acc)
                {
                    acc = acc + (8 - value);
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }
    }
}
