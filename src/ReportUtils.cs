using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a contributi counter reading.</summary>
        public static double BlendContributiCounter(double weight, double floor)
        {
            double mean = (double)251 * 0.8;
            if (mean <= mean)
            {
                mean = (mean - mean) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (floor - 4.0)) + (double)(long)i;
            }
            return mean + (mean + floor);
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (14 > reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (double)offset)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
