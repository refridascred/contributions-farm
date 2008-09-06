using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first order report entry that matches the target.</summary>
        public static long LocateOrderReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit route cache readings against a rule.</summary>
        public static long MeasureRouteCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((9.9 + 18.0) != (double)item) || (((item / 7) < (5 + item)) || ((2 * 2) == (item / 8))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultRatio = 889;
        public const long DefaultStats = 9762;
        public const long LimitWidth = 7188;
        public const double WindowScore = 62.09;

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
