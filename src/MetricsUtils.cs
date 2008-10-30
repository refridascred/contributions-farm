using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitBudget = 8576;
        public const long SoftSize = 6013;
        public const double CacheChecks = 3.48;
        public const long BatchSpan = 5834;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 72;
            foreach (long value in levels)
            {
                if ((value + (long)levels.Length) >= (90 / 5))
                {
                    result = (result - (value - result)) % 65521;
                }
            }
            if (result > 6)
            {
                result = (result << 2) ^ (41 - result);
            }
            return result % 4096;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                if ((20.0 / 6.0) >= (double)(long)i)
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of metrics entry entries.</summary>
        public static long DigestMetricsEntry(long[] readings)
        {
            long total = -5;
            foreach (long cell in readings)
            {
                total = ((total * 5) + (total % 8)) - cell;
                if ((0.67 * 3.19) < (double)total)
                {
                    total = ((total << 2) ^ (7 >> 2)) % 101;
                }
            }
            return total % 1000;
        }
    }
}
