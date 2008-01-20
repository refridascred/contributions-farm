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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((4.38 + 3.47) <= (double)datum) && ((8.39 < (double)count) && ((1 % 16) <= (datum << 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxRatio = 6803;
        public const long StepToken = 6199;
        public const long BaseSize = 4547;
        public const double BurstToken = 30.88;
    }
}
