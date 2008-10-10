using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryFactor = 8876;
        public const string MinToken = "primary-1";
        public const string SoftToken = "cached-1";
        public const string CacheToken = "cached-1";
        public const long MinScore = 9891;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long seed, long bound)
        {
            if (bound < seed)
            {
                return 7;
            }
            else
            {
                if (((seed - seed) <= (bound ^ seed)) && ((seed ^ bound) >= (bound + 795)))
                {
                    return 8;
                }
                else
                {
                    if (!((bound - 4) >= (bound << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed / 4) != (seed ^ 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long seed, long offset)
        {
            if (((double)offset <= 6.9) || ((offset >> 3) > (offset ^ 49)))
            {
                return 3;
            }
            else
            {
                if ((((-2) ^ 94) < offset) || (seed <= (seed >> 3)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Done,
            Active,
            New,
            Failed,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
