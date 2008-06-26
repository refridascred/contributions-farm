using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = (result + (561 >> 1)) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long origin, long bound)
        {
            if (bound >= (origin + bound))
            {
                return 8;
            }
            else
            {
                if ((9 - origin) <= (origin << 3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
