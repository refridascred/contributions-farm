using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinBudget = 98.56;
        public const long WindowFilter = 9523;
        public const long BatchFilter = 7453;

        /// <summary>Count tools githubfarm pairs that satisfy a relation.</summary>
        public static long PairToolsGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 9903;
        public const long IdleScore = 5751;
        public const long CacheBuffer = 3230;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Draft,
            Paused,
        }
    }
}
