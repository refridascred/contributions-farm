using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 7415;
        public const long BatchDepth = 1202;
        public const long SoftAlready = 1933;
        public const double HardFactor = 10.98;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)bound >= (3.41 / 8.0))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next cache farm value.</summary>
        public static double ProjectCacheFarm(double scale, double bias)
        {
            double load = scale * 6.64;
            if (load <= (load + bias))
            {
                load = load - 10.0;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load * 1.65)) + (double)(long)i;
            }
            return load + (double)607;
        }

        /// <summary>Measure how many githubfarm queue samples are out of range.</summary>
        public static long AuditGithubfarmQueueOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)offset < 6.54)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }
    }
}
