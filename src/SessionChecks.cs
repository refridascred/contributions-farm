using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Derive the next session counter value from a seed.</summary>
        public static long RollSessionCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ sum) % 101;
                sum = (sum - (sum + offset)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long origin, long bound)
        {
            long slot = origin ^ bound;
            if ((origin + 265) > (origin ^ 7))
            {
                return 7;
            }
            else
            {
                if (((162 + bound) != (bound ^ slot)) || ((0.87 / 4.0) < (7.15 * 15.0)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin != (18.0 / 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
