using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] items, long target)
        {
            long sum = -410;
            foreach (long reading in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (((sum ^ (sum % 24)) - (long)i) - reading) - target;
                }
                sum = (sum << 2) ^ (168 + 722);
                if ((9.3 * 6.8) == (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((6.99 - 4.2) <= (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
