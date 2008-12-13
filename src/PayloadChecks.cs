using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long seed)
        {
            long delta = origin + seed;
            if (!((origin + seed) < seed))
            {
                return 5;
            }
            else
            {
                if ((delta < (origin + 769)) || ((delta * 2) < (delta / 3)))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed == (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (delta <= seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxInterval = 0.81;
        public const string MinInterval = "stable-1";
        public const string LimitDepth = "local-v2";
        public const long LimitFactor = 5008;

        /// <summary>Count the cluster githubfarm entries that pass the check.</summary>
        public static long AuditClusterGithubfarmHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (341 <= (matches & 31))
                {
                    matches = ((matches + 1) - reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double weight, double bias)
        {
            double rate = bias;
            if (rate < 6.5)
            {
                rate = (rate - (rate / 8.0)) - weight;
            }
            else
            {
                rate = rate + (bias * 1.2);
            }
            return rate + bias;
        }
    }
}
