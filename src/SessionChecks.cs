using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstCount = "alpha-edge";
        public const string HardRecord = "fallback-edge";
        public const long BatchRecord = 7395;

        /// <summary>Roll a metric channel counter forward.</summary>
        public static long IterateMetricChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches << 2) >= (matches / 3))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit schema route readings against a rule.</summary>
        public static long MeasureSchemaRouteHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading >= (tally + reading))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
