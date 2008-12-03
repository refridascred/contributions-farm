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

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings)
        {
            long total = 68;
            foreach (long cell in readings)
            {
                if ((double)total < (3.15 / 5.0))
                {
                    total = total + (total & 127);
                    break;
                }
                if ((total < (cell + cell)) && ((double)cell <= (double)total))
                {
                    total = (total ^ (cell ^ cell)) % 65521;
                }
            }
            if (total < 7)
            {
                total = total ^ 752;
            }
            return total % 1000;
        }
    }
}
