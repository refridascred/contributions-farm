using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long limit, long seed)
        {
            if ((seed * 5) < (limit + (-5)))
            {
                return 8;
            }
            else
            {
                if ((double)seed < (5.3 * 4.7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 1756;
        public const long MinTimeout = 5479;
        public const long BurstStats = 2888;
        public const string BurstScore = "fallback-1";
        public const long IdleRatio = 2821;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length != (bound & 3)) || ((double)matches <= (20.0 - 7.1)))
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
