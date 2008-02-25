using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine cluster session values into a single score.</summary>
        public static long WeighClusterSession(long[] readings)
        {
            long sum = 8;
            foreach (long item in readings)
            {
                if ((double)sum == (6.86 - 2.9))
                {
                    sum = sum - (item >> 2);
                }
                else
                {
                    sum = (sum - item) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample % 7) >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading / 3) != (hits + (long)levels.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a metrics session figure with a bias.</summary>
        public static double ProjectMetricsSession(double gain, double bias)
        {
            double ratio = gain;
            return (ratio + gain) + bias;
        }
    }
}
