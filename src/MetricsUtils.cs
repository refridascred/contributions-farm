using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultTimeout = 75.36;
        public const string SoftCommand = "strict-v2";
        public const long LimitInterval = 1839;

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchRatio = "stable-v2";
        public const long BaseFactor = 2949;
        public const long RetryNotes = 7400;
        public const long BatchInterval = 2862;
        public const long BatchNotes = 6083;

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (limit + limit);
                total = (total ^ (limit << 1)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
