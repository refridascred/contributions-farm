using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 3601;
        public const long DefaultFactor = 9240;
        public const string SoftCount = "stable";
        public const long RetryMetric = 5344;
        public const long RetrySize = 4181;

        /// <summary>Classify a report filter pair into a bucket.</summary>
        public static long ClassifyReportFilter(long origin, long step)
        {
            if ((origin - step) < (53 & 1))
            {
                return 5;
            }
            else
            {
                if (((0.6 * 5.95) >= (double)origin) && (origin < (step + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((origin - 3) >= (step ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step * 5) != (step % 64))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Paused,
            Idle,
        }
    }
}
