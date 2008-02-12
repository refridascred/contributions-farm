using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double span)
        {
            double weight = span;
            if (weight >= weight)
            {
                weight = (weight + (double)3) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (double)9;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((18.0 * 4.9) > (double)(long)items.Length)
                {
                    tally = ((tally + 1) + cell) + floor;
                }
            }
            return tally;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long origin, long origin2)
        {
            long edge = origin + origin2;
            if (origin2 > (origin2 - origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (0.78 - 0.7))
                {
                    return 1;
                }
                else
                {
                    if ((origin - edge) > (origin2 + edge))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Locked,
            Done,
            Queued,
        }
    }
}
