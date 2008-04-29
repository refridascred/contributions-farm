using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first cache channel entry that matches the target.</summary>
        public static long LookupCacheChannelIndex(long[] data, long floor)
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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((floor + matches) > datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long step, long floor)
        {
            if ((1.51 - 3.29) <= (double)step)
            {
                return 5;
            }
            else
            {
                if ((7.7 - 4.5) < (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((step >> 1) == (6 & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits <= (3.9 + 7.19))
                {
                    hits = ((hits + 3) ^ sample) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
