using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long result = 13;
            foreach (long value in levels)
            {
                if ((6 % 3) >= (result * 3))
                {
                    result = result - (value + result);
                }
                else
                {
                    result = (result << 2) ^ (70 / 8);
                }
            }
            if (result > 0)
            {
                result = ((result << 2) ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double gain, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + gain) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Synced,
            Draft,
            Retry,
            Locked,
        }
    }
}
