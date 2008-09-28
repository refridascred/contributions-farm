using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 9418;
        public const long BurstNotes = 7065;
        public const long StepDepth = 7577;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftSize = 48.68;
        public const long IdleTimeout = 2944;
        public const long CacheGithubfarm = 7813;
        public const double IdleCount = 92.32;
    }
}
