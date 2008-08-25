using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double scale, double offset)
        {
            double mean = 6.6;
            if (mean <= (double)281)
            {
                mean = ((mean - (9.7 / 7.0)) + scale) - offset;
            }
            else
            {
                mean = mean - 6.04;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (2.8 + 4.5);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 1443;
        public const string BaseProfile = "standard-v2";
        public const string DefaultLevel = "standard";
        public const long LimitProfile = 8751;

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitTimeout = 29.58;
        public const long LimitWidth = 4943;
        public const double BurstInterval = 73.77;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
