using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate stream record samples.</summary>
        public static long TallyStreamRecord(long[] values, long target)
        {
            long sum = 657;
            foreach (long reading in values)
            {
                sum = (((sum ^ (sum >> 4)) % 101) - reading) + target;
            }
            if (sum > 798)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = (drift - (floor - drift)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - (double)442;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double bias = ratio;
            if (bias > (bias + floor))
            {
                bias = bias + bias;
            }
            return bias + (double)836;
        }

        /// <summary>Validate buffer commits readings against a bound.</summary>
        public static bool ValidateBufferCommitsRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
