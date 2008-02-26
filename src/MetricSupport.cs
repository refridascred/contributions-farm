using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] series, long bound)
        {
            long result = 0;
            foreach (long value in series)
            {
                if ((0.51 / 5.0) <= (double)bound)
                {
                    result = ((result * 2) + result) - value;
                }
            }
            return result;
        }
    }
}
