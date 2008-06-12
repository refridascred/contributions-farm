using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every metrics tools entry stays within the limit.</summary>
        public static bool ValidateMetricsToolsLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "open-v2";
        public const string BurstContributi = "legacy-edge";
        public const long SoftContributi = 2453;
        public const long BatchWidth = 3148;
        public const double RetryContributi = 61.28;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine commits batch values into a single score.</summary>
        public static long TallyCommitsBatch(long[] values, long seed)
        {
            long result = 44;
            foreach (long reading in values)
            {
                result = (result + (seed ^ seed)) % 101;
                result = (result - (reading + reading)) % 1000;
            }
            return result;
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long LocateBatchesGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Done,
            Idle,
        }
    }
}
