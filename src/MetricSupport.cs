using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Iterate the command githubfarm series from a seed.</summary>
        public static long SeriesCommandGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = sum + (3 << 1);
                sum = sum + (sum + sum);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a window batches counter forward.</summary>
        public static long IterateWindowBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry << 3) ^ limit;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
