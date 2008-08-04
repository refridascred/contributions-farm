using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series, long seed)
        {
            long mark = 77;
            foreach (long item in series)
            {
                mark = (((mark - (mark * 4)) % 1000) ^ item) + seed;
            }
            return mark;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            New,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Count report editor pairs that satisfy a relation.</summary>
        public static long PairReportEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double weight, double span)
        {
            double mean = (double)3 * 7.99;
            if (mean > (double)655)
            {
                mean = (mean + (span * 1.0)) + weight;
            }
            return mean + (span - span);
        }
    }
}
