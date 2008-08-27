using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 2658;
        public const long SoftLevel = 8738;
        public const long SoftWidth = 7783;
        public const string BatchRecord = "legacy-v2";
        public const long LimitInterval = 9187;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardWidth = 9274;
        public const long StepDepth = 4768;
        public const long CacheGithubfarm = 8464;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double drift = (double)((-853) + 34);
            if (drift > 10.0)
            {
                drift = (drift - (double)0) - weight;
            }
            else
            {
                drift = drift + (bias - bias);
            }
            return drift - (bias + 9.1);
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i < (sum % 2))
                {
                    sum = (sum - limit) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
