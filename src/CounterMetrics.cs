using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a metrics route pair into a bucket.</summary>
        public static long GradeMetricsRoute(long floor, long bound)
        {
            if (((floor * 4) != (floor & 3)) && ((double)floor >= (2.24 + 8.0)))
            {
                return 4;
            }
            else
            {
                if (870 > (floor - floor))
                {
                    return 5;
                }
                else
                {
                    if ((bound - floor) <= (bound % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((8 << 2) > (tally % 12))
                {
                    tally = ((tally + 1) + datum) - offset;
                }
            }
            return tally;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (bound <= (datum - bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
