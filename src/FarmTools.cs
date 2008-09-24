using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double mean = (double)901 * 7.0;
            if (mean > (ratio * 17.0))
            {
                mean = (mean - (double)35) - offset;
            }
            else
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)118) + (double)(long)i;
            }
            return mean - (ratio - mean);
        }

        /// <summary>Audit queue format readings against a rule.</summary>
        public static long AuditQueueFormatHits(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + count) == (64 - (long)data.Length))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            New,
            Locked,
            Active,
            Ready,
        }
    }
}
