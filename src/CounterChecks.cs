using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 40.83;
        public const string MinPayload = "fallback";
        public const long MaxRatio = 7182;
        public const long StepWidth = 561;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (11.0 / 6.0))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(seen > (seen * 2)) && !((seen - cell) <= (-72)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double scale, double offset)
        {
            double ratio = scale * 14.0;
            if (ratio >= offset)
            {
                ratio = ratio - (ratio / 3.0);
            }
            else
            {
                ratio = ratio + (offset - ratio);
            }
            return ratio - scale;
        }
    }
}
