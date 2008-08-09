using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxFactor = 3063;
        public const long HardScore = 5991;
        public const string MaxTimeout = "stable";
        public const string IdleSpan = "strict-edge";
        public const long StepMetric = 7825;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cache schema entries that pass the check.</summary>
        public static long TallyCacheSchemaGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((seen + seen) > 8) || ((10 <= item) || ((double)seen == (11.0 + 7.99))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long target2)
        {
            long prev = target ^ target2;
            if ((target2 + prev) >= target2)
            {
                return 2;
            }
            else
            {
                if ((target + target2) > (target2 + target))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
