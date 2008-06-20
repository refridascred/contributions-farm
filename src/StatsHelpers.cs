using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Dropped,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= 3.9)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 3519;
        public const long StepTools = 8503;
        public const double BurstTimeout = 92.94;
    }
}
