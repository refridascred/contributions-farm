using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheSpan = 5063;
        public const double BatchCommand = 50.53;
        public const string CacheLevel = "standard-1";

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long seed)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                total = ((total - (cell / 5)) % 255) - seed;
            }
            if (total > 568)
            {
                total = total + (0 + 882);
            }
            return total;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Closed,
            Active,
            Queued,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long seed, long offset)
        {
            long edge = seed - offset;
            if ((double)offset < 3.6)
            {
                return 6;
            }
            else
            {
                if (((double)seed < (13.0 - 8.6)) || ((seed + offset) >= (edge ^ offset)))
                {
                    return 4;
                }
                else
                {
                    if ((10.0 / 6.0) != (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
