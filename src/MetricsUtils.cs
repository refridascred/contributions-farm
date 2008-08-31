using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data)
        {
            long result = 3;
            foreach (long item in data)
            {
                if ((result % 16) >= (result + result))
                {
                    result = (result ^ (item >> 5)) % 4096;
                    break;
                }
                if (item <= (result - result))
                {
                    result = (result * 5) + 3;
                }
                if ((double)item > (2.0 + 3.78))
                {
                    result = (result ^ (result / 4)) % 255;
                }
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batches batch entries that pass the check.</summary>
        public static long AuditBatchesBatchOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((61 >> 3) < step)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double rate, double span)
        {
            double scale = span;
            if (scale <= (double)94)
            {
                scale = (scale - (double)26) - rate;
            }
            else
            {
                scale = scale + (span * 7.23);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (5.09 + scale)) + (double)(long)i;
            }
            return scale - (scale / 5.0);
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally >= (0.8 + 17.0))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}
