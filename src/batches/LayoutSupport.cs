using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches > (cell << 3))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((4.8 / 4.0) > (double)limit)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Size { get; set; }
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Draft,
            Locked,
            Paused,
        }
    }
}
