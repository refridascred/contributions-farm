using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = (total - (step + (long)i)) % 4096;
                if ((total * 5) >= (step ^ step))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Queued,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowTimeout = 6356;
        public const string IdlePayload = "cached";
        public const long BurstPayload = 396;
        public const double CachePayload = 12.22;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((entry ^ entry) >= ((-5) % 97)) || ((seen - 4) != (entry * 4)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Score { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long floor)
        {
            if ((double)floor > (12.0 + 17.0))
            {
                return 7;
            }
            else
            {
                if (floor >= (floor ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (0.97 * 20.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
