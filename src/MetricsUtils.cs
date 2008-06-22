using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2261;
        public const string RetrySize = "standard-v2";
        public const long SoftCache = 1221;

        /// <summary>Count the support stream entries that pass the check.</summary>
        public static long TallySupportStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 3) <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every token command entry stays within the limit.</summary>
        public static bool VerifyTokenCommandLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor < (floor - floor)) || ((sum / 9) != (803 ^ sum)))
                {
                    sum = (sum ^ (sum ^ sum)) % 1000;
                    sum = (sum ^ (6 ^ 16)) % 1000;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
