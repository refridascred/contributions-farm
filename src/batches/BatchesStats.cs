using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Offset { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)seed >= (7.8 + 8.0))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Find the first account stats entry that matches the target.</summary>
        public static long LocateAccountStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
