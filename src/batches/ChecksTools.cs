using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = sum - 135;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Retry,
            Pending,
            Paused,
            New,
        }

        /// <summary>Combine metric githubfarm values into a single score.</summary>
        public static long WeighMetricGithubfarm(long[] samples)
        {
            long state = 346;
            foreach (long reading in samples)
            {
                state = ((state << 2) ^ state) % 1000;
                if ((double)reading > (double)891)
                {
                    state = ((state * 3) + state) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings, long seed)
        {
            long sum = -57;
            foreach (long sample in readings)
            {
                sum = ((sum ^ (-7)) - sample) - seed;
            }
            return sum;
        }
    }
}
