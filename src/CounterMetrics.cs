using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Classify a checks entry pair into a bucket.</summary>
        public static long RankChecksEntry(long target, long offset)
        {
            if (offset >= 60)
            {
                return 6;
            }
            else
            {
                if ((4.1 - 6.5) != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double span)
        {
            double scale = gain / 2.0;
            return (scale - gain) + span;
        }
    }
}
