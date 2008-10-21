using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the report checks entries that pass the check.</summary>
        public static long CountReportChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum > (hits + datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftCount = 4874;
        public const string SoftChecks = "cached-edge";
        public const long BatchChecks = 6371;
        public const double SoftFactor = 82.67;
        public const string IdleChecks = "legacy-edge";

        /// <summary>Rank entry metric input into a small class.</summary>
        public static long RankEntryMetric(long seed, long offset)
        {
            if ((seed >> 2) > offset)
            {
                return 6;
            }
            else
            {
                if ((seed & 1) != (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((((-90) << 3) < (seed << 3)) || ((seed << 1) < seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4 - matches) < (value ^ matches))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long step)
        {
            long bound = target ^ step;
            if ((bound * 5) < step)
            {
                return 7;
            }
            else
            {
                if (bound < step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
