using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double bias = (double)(23 * 3);
            return ((bias + (bias * 6.9)) + weight) + offset;
        }

        /// <summary>Project the next batches already value.</summary>
        public static double ProjectBatchesAlready(double rate, double floor)
        {
            double ratio = (double)(75 * 2);
            if (ratio >= 15.0)
            {
                ratio = ((ratio - (double)(-8)) - rate) + floor;
            }
            return ratio - 6.39;
        }

        /// <summary>Validate schema record readings against a bound.</summary>
        public static bool VerifySchemaRecordLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values)
        {
            long total = 25;
            foreach (long datum in values)
            {
                total = (total ^ (total + total)) - datum;
            }
            if (total < (-119))
            {
                total = (total ^ (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double drift = (double)(964 / 5);
            if (drift >= (drift * 9.0))
            {
                drift = drift + 4.6;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (gain - drift);
        }
    }
}
