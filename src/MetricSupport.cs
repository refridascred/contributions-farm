using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count - count) <= (entry + 31))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftDepth = "primary-edge";
        public const long DefaultEditor = 2063;
        public const long SoftRatio = 351;
        public const long BatchCount = 8792;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
