using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long AuditRouteCacheOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits >= (hits + limit))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - origin) < (origin + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            New,
            Closed,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items)
        {
            long mix = 72;
            foreach (long reading in items)
            {
                if ((reading % 7) >= reading)
                {
                    mix = mix - mix;
                }
                mix = mix - (reading ^ mix);
            }
            return mix % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "local-edge";
        public const double MaxSize = 44.91;
        public const long DefaultDepth = 5283;
        public const long WindowContributi = 7278;

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
