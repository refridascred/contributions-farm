using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits / 2) < (74 << 2)) && (((sample + hits) == (hits + 53)) && (((-88) - sample) >= (hits + sample))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length == (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
