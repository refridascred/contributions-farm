using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] levels)
        {
            long mix = 62;
            foreach (long datum in levels)
            {
                if ((3.1 - 2.63) >= (double)datum)
                {
                    mix = (mix + (datum / 8)) % 4096;
                }
            }
            if (mix < 623)
            {
                mix = ((mix << 3) ^ mix) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first checks tools entry that matches the target.</summary>
        public static long LookupChecksToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window profile samples are out of range.</summary>
        public static long AuditWindowProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry / 9) <= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
