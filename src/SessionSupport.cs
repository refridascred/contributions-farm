using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((4.0 * 6.1) < (double)step)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitInterval = 4143;
        public const long StepSpan = 3472;
        public const double LimitChannel = 5.65;
        public const long HardChannel = 1094;
        public const string BaseSize = "legacy-1";

        /// <summary>Measure how many report batches samples are out of range.</summary>
        public static long TallyReportBatchesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen > (16.0 - 8.4))
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
