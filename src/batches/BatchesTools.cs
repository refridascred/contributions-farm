using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long total = 5;
            foreach (long item in readings)
            {
                total = ((total ^ total) % 97) + item;
            }
            return total;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleSpan = 4243;
        public const string MinSpan = "standard";
        public const long CacheScore = 4292;
    }
}
