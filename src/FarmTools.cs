using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a context metrics pair into a bucket.</summary>
        public static long ClassifyContextMetrics(long seed, long step)
        {
            if (((double)seed > 5.26) && ((16.0 + 9.04) == (double)seed))
            {
                return 8;
            }
            else
            {
                if (step <= (seed ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 7) <= (step ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
