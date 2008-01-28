using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double weight = (double)(434 - 77);
            if (weight < rate)
            {
                weight = (weight + rate) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)127) + (double)(long)i;
            }
            return weight - 2.0;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(((hits * 5) >= (884 % 100)) && ((double)value > (double)(long)values.Length)))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] series)
        {
            long score = 30;
            foreach (long value in series)
            {
                if (((score % 7) == (4 + score)) && ((value - value) >= (value + value)))
                {
                    score = ((score * 5) + (long)series.Length) % 255;
                }
                else
                {
                    score = ((score * 3) + (score * 4)) % 65521;
                }
            }
            if (score > 3)
            {
                score = (score + (3 * 3)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
