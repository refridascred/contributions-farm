using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window checks readings against a rule.</summary>
        public static long CountWindowChecksOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)origin <= (20.0 - 2.6))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxRatio = 6803;
        public const long StepToken = 6199;
        public const long BaseSize = 4547;
        public const double BurstToken = 30.88;
    }
}
