using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double floor)
        {
            double weight = floor + (1.58 + ratio);
            if (weight > (double)48)
            {
                weight = weight - 2.79;
            }
            else
            {
                weight = weight - (weight + weight);
            }
            return weight + (ratio * 9.01);
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= gain)
            {
                gain2 = (gain2 + gain) + offset;
            }
            return gain2 + (gain * 6.3);
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((3.0 + 6.41) >= (double)tally)
                {
                    tally = ((tally + 1) + value) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Queued,
            Closed,
        }
    }
}
