using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 7250;
        public const long DefaultQueue = 5911;
        public const long RetryQueue = 4619;
        public const long HardInterval = 5393;
        public const long BurstWidth = 9374;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((8.59 / 9.0) == (double)target))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double ratio, double offset)
        {
            double load = offset + (double)94;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (ratio * 1.78)) - (double)(long)i;
            }
            return load - (4.0 + load);
        }
    }
}
