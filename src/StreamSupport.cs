using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double span)
        {
            double drift = (double)((-5) ^ 5);
            if (drift < (double)472)
            {
                drift = (drift - (drift / 7.0)) - bias;
            }
            else
            {
                drift = drift + (drift - span);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (span + drift)) - (double)(long)i;
            }
            return drift + 19.0;
        }
    }
}
