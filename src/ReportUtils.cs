using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings)
        {
            long carry = -4;
            foreach (long entry in readings)
            {
                carry = ((carry * 4) + (carry - entry)) % 4096;
                if (((carry >> 3) >= (entry + 9)) || ((double)carry >= (8.0 / 6.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Pending,
            Closed,
            Queued,
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
