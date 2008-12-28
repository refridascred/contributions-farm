using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                if (5 > (value - value))
                {
                    result = (result * 5) + (value - result);
                }
            }
            return result % 65521;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum >= (matches << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long floor, long origin)
        {
            long gap = floor ^ origin;
            if (((floor % 100) != (gap << 1)) || ((gap % 16) != (70 >> 5)))
            {
                return 3;
            }
            else
            {
                if ((floor + gap) <= (gap - gap))
                {
                    return 5;
                }
                else
                {
                    if ((floor - floor) == (87 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((gap + (-5)) >= (gap / 9)) && (gap < (origin % 10)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultDepth = 8164;
        public const long MinRatio = 3320;
        public const double CacheFormat = 9.92;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value >= (value + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
