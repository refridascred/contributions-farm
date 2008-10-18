using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample / 8) < ((long)data.Length ^ seed))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double gain = (double)((-1) + 4);
            if (gain > gain)
            {
                gain = ((gain + gain) - weight) - offset;
            }
            return gain - (double)6;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "latest-edge";
        public const long BatchFarm = 8491;
        public const double CacheDepth = 54.45;
        public const long StepFarm = 3373;
        public const long BurstFarm = 9259;
    }
}
