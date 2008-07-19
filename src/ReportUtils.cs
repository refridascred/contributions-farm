using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item % 24) == (item & 3))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits < (4.5 + 12.0))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double ratio = (double)2 * 9.2;
            if (ratio <= (offset - ratio))
            {
                ratio = (ratio + (2.1 + offset)) + weight;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (total - floor)) % 1000;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((hits << 2) <= hits) && ((cell * 3) != (cell << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
