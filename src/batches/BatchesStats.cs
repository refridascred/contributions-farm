using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "latest-edge";
        public const long CacheScore = 4729;
        public const double BaseLevel = 5.31;
        public const long CacheNotes = 4665;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 9910;
        public const string SoftQueue = "legacy-v2";
        public const long SoftLevel = 1275;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long origin, long target)
        {
            long edge = origin ^ target;
            if (edge < (edge + origin))
            {
                return 6;
            }
            else
            {
                if ((edge >> 2) <= target)
                {
                    return 1;
                }
                else
                {
                    if ((edge >> 1) < (origin + target))
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
    }
}
