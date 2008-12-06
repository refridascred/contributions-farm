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

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] samples)
        {
            long sum = 54;
            foreach (long datum in samples)
            {
                if (((sum % 16) >= (4 * 2)) || ((sum & 31) == (637 + sum)))
                {
                    sum = sum ^ (sum + datum);
                }
            }
            if (sum > 4)
            {
                sum = ((sum * 3) + sum) % 101;
            }
            return sum % 97;
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
