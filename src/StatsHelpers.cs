using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Count window layout pairs that satisfy a relation.</summary>
        public static long CompareWindowLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many command support samples are out of range.</summary>
        public static long MeasureCommandSupportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count << 3) != (count * 2))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSpan = 4504;
        public const long BaseTimeout = 2280;
        public const long BaseLevel = 8560;
        public const long LimitCount = 9138;
    }
}
