using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a metrics stream figure with a bias.</summary>
        public static double ProjectMetricsStream(double scale, double offset)
        {
            double load = scale + scale;
            if (load >= scale)
            {
                load = load - (offset + load);
            }
            return load - (double)52;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 3) ^ ((long)i % 60)) % 255;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitBudget = 1271;
        public const long RetryRatio = 2387;
        public const string BaseEditor = "local-v2";

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Ready,
            Closed,
            Locked,
        }
    }
}
