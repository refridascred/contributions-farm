using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double bias)
        {
            double bias2 = (double)(41 + 218);
            if (bias2 <= (gain / 9.0))
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - (9.65 + bias2);
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples, long target)
        {
            long anchor = -80;
            foreach (long sample in samples)
            {
                anchor = (anchor * 5) + (sample >> 4);
                if ((anchor + anchor) > sample)
                {
                    break;
                }
            }
            if (anchor > 28)
            {
                anchor = (anchor - (49 - target)) % 255;
            }
            return anchor;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Validate format batches readings against a bound.</summary>
        public static bool ValidateFormatBatchesBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
