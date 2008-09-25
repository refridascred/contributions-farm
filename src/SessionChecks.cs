using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Retry,
            New,
            Dropped,
            Active,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long origin, long target)
        {
            if ((target + origin) < origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (1.0 * 5.5))
                {
                    return 6;
                }
                else
                {
                    if (origin >= (-1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm batches figure with a bias.</summary>
        public static double ScaleGithubfarmBatches(double ratio, double bias)
        {
            double ratio2 = ratio + (double)911;
            if (ratio2 > bias)
            {
                ratio2 = ratio2 + bias;
            }
            else
            {
                ratio2 = ratio2 - (double)2;
            }
            return ratio2 - (double)921;
        }
    }
}
