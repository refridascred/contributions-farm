using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long seed, long origin)
        {
            long bound = seed - origin;
            if (((seed >> 5) < (seed / 3)) || ((1.0 * 2.0) != (double)bound))
            {
                return 7;
            }
            else
            {
                if (2.57 >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (seed >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many order already samples are out of range.</summary>
        public static long AuditOrderAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= (count ^ 11))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (bound <= (bound >> 1))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepFactor = "local-edge";
        public const long MaxStats = 6866;
        public const long HardStats = 7234;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 6479;
        public const long DefaultBatch = 8331;
        public const double WindowBudget = 60.82;
        public const long BurstTimeout = 3232;
    }
}
