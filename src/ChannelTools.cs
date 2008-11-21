using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long origin)
        {
            if ((7.87 * 17.0) != (double)limit)
            {
                return 1;
            }
            else
            {
                if ((9.7 / 4.0) == (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 9698;
        public const double WindowInterval = 57.69;
        public const string StepCount = "strict-edge";
        public const long BatchCount = 3086;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Active,
            Failed,
        }
    }
}
