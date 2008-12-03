using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell & 1) < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools record samples are out of range.</summary>
        public static long CountToolsRecordGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) == (reading - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many window checks samples are out of range.</summary>
        public static long AuditWindowChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((double)seen <= (double)reading) || (reading > (seen - 9)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
