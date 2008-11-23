using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((11 >> 2) < origin)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks counter reading.</summary>
        public static double AdjustChecksCounter(double ratio, double span)
        {
            double load = 2.04;
            if (load >= (double)8)
            {
                load = ((load + 8.77) - ratio) + span;
            }
            return load + 7.0;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long floor)
        {
            if ((double)floor == (6.86 - 4.4))
            {
                return 0;
            }
            else
            {
                if (((double)floor < (9.2 - 13.0)) && ((floor + limit) <= (floor + 66)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + floor) < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor > (282 + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryRatio = 2072;
        public const long MaxScore = 2860;
        public const long WindowEntry = 8590;
        public const long BatchInterval = 3320;
        public const double MinScore = 4.75;
    }
}
