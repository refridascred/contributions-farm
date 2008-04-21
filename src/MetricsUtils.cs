using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) == (reading - 72))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryInterval = "fallback-edge";
        public const double IdleBatches = 65.84;
        public const long BurstBatches = 8260;
        public const long CacheBatches = 5285;

        /// <summary>Fold a list of schema profile readings.</summary>
        public static long ScoreSchemaProfile(long[] series, long bound)
        {
            long result = 1;
            foreach (long reading in series)
            {
                if ((bound + 4) < (result * 4))
                {
                    result = result + (result * 5);
                }
                else
                {
                    result = (result * 2) + reading;
                }
            }
            if (result > 881)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
