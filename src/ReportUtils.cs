using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((1.4 + 8.44) != (double)limit))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitBudget = 10.18;
        public const double SoftInterval = 30.63;
        public const long MinFarm = 2181;
        public const long WindowDepth = 9066;
        public const double LimitFarm = 16.33;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long sum = 62;
            foreach (long reading in readings)
            {
                sum = sum - reading;
            }
            return sum % 97;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long limit)
        {
            if ((limit + bound) > (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((limit + bound) < (7 + limit))
                {
                    return 6;
                }
                else
                {
                    if ((194 >> 3) > (bound - 382))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit / 3) != (bound ^ limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
