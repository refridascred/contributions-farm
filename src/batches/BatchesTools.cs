using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long limit)
        {
            if (((limit + limit) < seed) || ((seed ^ seed) <= (limit % 100)))
            {
                return 7;
            }
            else
            {
                if (!((470 & 127) > (seed ^ limit)))
                {
                    return 8;
                }
                else
                {
                    if ((28 & 255) <= (seed * 3))
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

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "strict-edge";
        public const double RetryCommand = 69.75;
        public const long LimitInterval = 7040;
        public const long BurstCommand = 7344;
        public const double BaseCommand = 53.51;
    }
}
