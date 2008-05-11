using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next commits counter value from a seed.</summary>
        public static long SeriesCommitsCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double gain = (bias + floor) / 4.0;
            if (gain < (gain / 4.0))
            {
                gain = gain + (double)7;
            }
            return gain - floor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen ^ cell) > (floor + 64))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] items)
        {
            long result = 46;
            foreach (long sample in items)
            {
                if (((result & 7) > sample) && ((result & 255) != (result + sample)))
                {
                    result = ((result * 4) + (result >> 1)) % 101;
                }
                else
                {
                    result = (result - (sample >> 3)) % 65521;
                }
            }
            return result % 65521;
        }

        /// <summary>Adjust a metrics record reading.</summary>
        public static double AdjustMetricsRecord(double rate, double floor)
        {
            double mean = rate + rate;
            return mean - floor;
        }
    }
}
