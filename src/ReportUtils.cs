using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a context stream reading.</summary>
        public static double SmoothContextStream(double bias, double span)
        {
            double ratio = (bias + span) / 2.0;
            if (ratio < (double)90)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + 18.0;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Retry,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double gain, double floor)
        {
            double drift = (gain - gain) * 3.1;
            if (drift > (floor + gain))
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift + (drift + 8.1);
            }
            return drift + (drift / 4.0);
        }

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value * 3) <= (matches / 6)) || !((matches << 3) < (matches * 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
