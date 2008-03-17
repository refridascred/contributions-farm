using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (floor < (datum & 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double mean = offset;
            if (mean >= (double)7)
            {
                mean = mean - 4.37;
            }
            else
            {
                mean = mean - (double)438;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((510 / 2) == (count - 26))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
