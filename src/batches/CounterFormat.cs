using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double ratio2 = 3.0;
            if (ratio2 < (ratio + ratio2))
            {
                ratio2 = (ratio2 - (ratio2 / 2.0)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (18.0 * 5.5)) + (double)(long)i;
            }
            return ratio2 + (ratio2 - ratio);
        }
    }
}
