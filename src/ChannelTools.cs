using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry % 8) >= (entry << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double ratio, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (mean / 8.0);
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count + count) > (origin << 1)) && ((value % 64) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
