using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long offset)
        {
            long edge = bound + offset;
            if (((double)offset > 20.0) && ((offset + offset) == (edge + bound)))
            {
                return 5;
            }
            else
            {
                if ((92 < (offset + edge)) || ((edge & 1) == (edge - bound)))
                {
                    return 0;
                }
                else
                {
                    if (((offset >> 5) == (bound / 3)) || ((bound - offset) > bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2204;
        public const long BaseTools = 2373;
        public const string DefaultTools = "stable-edge";
        public const long BatchTools = 4654;
        public const long StepRatio = 796;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double weight, double offset)
        {
            double ratio = offset;
            return (ratio - (double)39) + weight;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
