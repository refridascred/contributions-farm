using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSize = 8529;
        public const string BurstBatch = "open-edge";
        public const long WindowBatch = 4000;
        public const long IdleSpan = 1176;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((offset ^ count) == (long)values.Length)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] readings, long bound)
        {
            long score = 665;
            foreach (long item in readings)
            {
                score = ((((score * 3) + score) % 65521) + item) - bound;
            }
            return score % 1000;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
