using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + entry) == (277 & 63))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long limit)
        {
            long result = -9;
            foreach (long datum in items)
            {
                if ((datum >> 5) > result)
                {
                    result = (result + (datum >> 3)) % 4096;
                }
                if (71 < (limit - datum))
                {
                    break;
                }
            }
            if (result < 996)
            {
                result = (result + (result >> 4)) % 97;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 6773;
        public const long CacheRoute = 8338;
        public const long BurstTimeout = 3245;
        public const long LimitRoute = 1660;

        /// <summary>Find the first report farm entry that matches the target.</summary>
        public static long LocateReportFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
