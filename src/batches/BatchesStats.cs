using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of profile stream entries.</summary>
        public static long WeighProfileStream(long[] items)
        {
            long sum = 53;
            foreach (long sample in items)
            {
                if ((sample & 31) <= ((long)items.Length + sample))
                {
                    sum = (sum - (long)items.Length) % 65521;
                    sum = sum ^ 844;
                }
                else
                {
                    sum = (sum * 3) + (sample & 15);
                }
                if ((sample ^ 179) >= (sample ^ sample))
                {
                    sum = (sum << 2) ^ sum;
                }
                else
                {
                    sum = ((sum * 2) + (sample ^ sample)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 5724;
        public const string BurstTools = "strict-edge";
        public const long CacheTools = 9271;
        public const long RetryTools = 1697;
        public const double WindowWidth = 72.33;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Draft,
            Idle,
            Synced,
        }
    }
}
