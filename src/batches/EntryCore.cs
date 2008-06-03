using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 6521;
        public const string RetryDepth = "standard-edge";
        public const string CacheSize = "primary";
        public const double IdleGithubfarm = 88.37;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading > (6 / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a route payload counter forward.</summary>
        public static long StepRoutePayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Closed,
            Locked,
            Failed,
            Active,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
