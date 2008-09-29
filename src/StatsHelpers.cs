using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const long MinBudget = 1591;
        public const long IdleSpan = 5177;
        public const double MinRatio = 18.95;
        public const long LimitEntry = 3100;

        /// <summary>Classify a cache tools pair into a bucket.</summary>
        public static long GradeCacheTools(long seed, long limit)
        {
            long edge = seed + limit;
            if (seed >= (limit - edge))
            {
                return 2;
            }
            else
            {
                if ((edge + 939) > edge)
                {
                    return 7;
                }
                else
                {
                    if ((seed + 336) <= (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(0 < (edge + 831)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 6277;
        public const long BurstBudget = 6571;
        public const long SoftNotes = 7764;
        public const double StepNotes = 13.4;
        public const long BurstNotes = 1076;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
