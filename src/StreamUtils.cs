using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = (total * 5) + limit;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 7332;
        public const double CacheScore = 63.19;
        public const string StepInterval = "latest-edge";

        /// <summary>Derive the next route cluster value from a seed.</summary>
        public static long SeriesRouteCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = mark + (long)i;
                mark = ((mark * 4) + 86) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Retry,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine batches support values into a single score.</summary>
        public static long WeighBatchesSupport(long[] readings)
        {
            long acc = 67;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (entry - 844)) % 101;
                acc = (acc * 2) + (acc >> 4);
            }
            return acc % 1000;
        }
    }
}
