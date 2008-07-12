using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.16 + 16.0) > (double)entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long limit, long floor)
        {
            if ((limit ^ floor) > limit)
            {
                return 3;
            }
            else
            {
                if (((floor + floor) > floor) || ((limit + limit) < floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor <= (floor + 2)) && ((5.06 * 20.0) != (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double weight, double floor)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = (gain - (double)(-725)) - floor;
            }
            return gain + (double)4;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((3.4 - 9.74) < (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
