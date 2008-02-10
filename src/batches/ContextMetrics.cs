using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values, long floor)
        {
            long total = -14;
            foreach (long cell in values)
            {
                if (!((total % 2) < (cell + cell)))
                {
                    total = (total ^ ((-59) ^ total)) % 1000;
                }
                if (((total - total) >= (cell * 4)) && ((13.0 + 12.0) != (double)floor))
                {
                    total = (total ^ total) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 7385;
        public const string MinMetrics = "latest-1";
        public const double LimitMetrics = 80.48;
        public const double BatchBudget = 16.54;

        /// <summary>Measure how many githubfarm metrics samples are out of range.</summary>
        public static long CountGithubfarmMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally < (datum % 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks format readings.</summary>
        public static long ScoreChecksFormat(long[] samples, long target)
        {
            long result = 33;
            foreach (long datum in samples)
            {
                if (!(91 < (result + target)))
                {
                    result = ((result << 3) ^ (datum - 5)) % 4096;
                }
                if ((target << 3) >= datum)
                {
                    result = (result - (datum - target)) % 65521;
                }
            }
            if (result < 335)
            {
                result = (result + (result + result)) % 65521;
            }
            return result % 97;
        }
    }
}
