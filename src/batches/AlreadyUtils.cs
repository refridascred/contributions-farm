using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitCount = 96.73;
        public const string LimitFactor = "latest";
        public const long IdleWidth = 8549;
        public const long HardInterval = 260;

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double bias, double floor)
        {
            double mean = floor;
            if (mean < 9.66)
            {
                mean = mean - (double)19;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean + bias;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Pending,
            Draft,
            Synced,
            Failed,
        }
    }
}
