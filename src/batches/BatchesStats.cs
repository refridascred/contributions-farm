using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 597;
        public const long CacheWindow = 2735;
        public const double MaxRatio = 62.37;
        public const string DefaultBudget = "latest-1";
        public const long HardWidth = 208;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double gain = (double)(4 >> 1);
            return ((gain + (2.54 - gain)) + rate) + span;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 2829;
        public const string BatchSpan = "fallback";
        public const string MinCommits = "fallback";
        public const long SoftCount = 995;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long target)
        {
            if (origin < 994)
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < (origin + target))
                {
                    return 8;
                }
                else
                {
                    if ((target & 1) <= (origin - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.95) == (double)target)
                        {
                            return 4;
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
}
