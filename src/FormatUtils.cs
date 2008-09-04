using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long origin, long origin2)
        {
            if ((682 & 255) <= (origin >> 1))
            {
                return 0;
            }
            else
            {
                if (((origin2 - origin2) >= (29 - 2)) || ((double)origin2 < (1.49 / 9.0)))
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (origin2 - origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double mean = 9.0;
            if (mean < mean)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - floor;
            }
            return mean - mean;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double weight, double offset)
        {
            double rate = (offset + offset) / 3.0;
            return (rate + (double)980) + weight;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((3.3 + 7.6) >= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Draft,
            Pending,
            Closed,
            Ready,
        }
    }
}
