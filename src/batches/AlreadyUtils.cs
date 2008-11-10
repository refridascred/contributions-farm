using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((floor ^ floor) < (cell << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long limit)
        {
            long sum = 546;
            foreach (long item in samples)
            {
                if ((limit ^ (long)samples.Length) >= (sum - limit))
                {
                    continue;
                }
                sum = (sum + (sum / 9)) ^ item;
                sum = sum + (limit << 3);
            }
            return sum % 97;
        }
    }
}
