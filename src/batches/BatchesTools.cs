using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long AuditEditorCacheOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count * 4) <= (target >> 1))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Project the next tools batch value.</summary>
        public static double ProjectToolsBatch(double gain, double floor)
        {
            double ratio = (double)(0 >> 4);
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio - (ratio - 9.6)) - (double)(long)i) - gain) + floor;
            }
            return ratio - (1.6 * 1.8);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
