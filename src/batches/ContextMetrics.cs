using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long origin, long target)
        {
            if (((origin + 102) <= 1) || ((0 - 33) != (origin ^ target)))
            {
                return 5;
            }
            else
            {
                if ((origin & 255) >= target)
                {
                    return 8;
                }
                else
                {
                    if ((8 << 1) <= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchInterval = "stable-1";
        public const long WindowBudget = 634;
        public const long StepPayload = 2164;

        /// <summary>Audit channel commits readings against a rule.</summary>
        public static long MeasureChannelCommitsMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 2) != (reading % 2))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "strict-v2";
        public const long RetrySpan = 2072;
        public const string HardSize = "stable";
        public const double BaseInterval = 9.07;
    }
}
