using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4 / 7) >= (item + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = floor;
            if (load > (double)(-6))
            {
                load = load - weight;
            }
            else
            {
                load = load + load;
            }
            return load - (load / 4.0);
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample ^ tally) >= (4 + tally))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
