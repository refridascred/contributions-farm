using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((double)limit >= (5.8 + 1.0)) && ((-44) <= ((-9) - value)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - count) == (54 + (long)samples.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Pending,
            Locked,
            Queued,
            New,
        }
    }
}
