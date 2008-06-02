using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double scale = gain;
            if (scale < (scale + gain))
            {
                scale = (scale + gain) - span;
            }
            else
            {
                scale = scale + (double)460;
            }
            return scale + (scale * 3.0);
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Draft,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 5764;
        public const long DefaultSpan = 6151;
        public const double LimitLayout = 10.56;
        public const long MaxCount = 4966;
        public const long RetryRatio = 5232;

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double rate = gain;
            if (rate >= (double)7)
            {
                rate = (rate - gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}
