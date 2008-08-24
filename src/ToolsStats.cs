using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2210;
        public const double IdleLevel = 61.37;
        public const long LimitTools = 4171;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 31.94;
        public const long MinFilter = 9792;
        public const long StepInterval = 1416;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Idle,
            Failed,
            Paused,
        }
    }
}
