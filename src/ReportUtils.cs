using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double weight, double span)
        {
            double gain = (double)(69 * 4);
            return (gain - (weight - weight)) + span;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a schema payload pair into a bucket.</summary>
        public static long ClassifySchemaPayload(long origin, long seed)
        {
            if (!((double)seed < (7.4 + 8.0)))
            {
                return 3;
            }
            else
            {
                if ((origin < seed) && ((double)origin < (double)seed))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin < (1.76 * 6.61)) && ((double)origin >= 1.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Locked,
            Dropped,
            Retry,
        }
    }
}
