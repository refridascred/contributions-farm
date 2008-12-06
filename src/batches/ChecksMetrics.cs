using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many filter token samples are out of range.</summary>
        public static long MeasureFilterTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((41 + item) > (item - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 8090;
        public const long WindowWidth = 2931;
        public const double MinFactor = 98.33;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((double)count < 10.0) || ((double)datum <= (18.0 * 6.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a command metric reading by value.</summary>
        public static long FindCommandMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFactor = "strict";
        public const string BatchSize = "primary";
        public const long BurstDepth = 1279;
    }
}
