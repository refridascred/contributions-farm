using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double gain, double span)
        {
            double load = (double)(70 << 2);
            if (load <= span)
            {
                load = load - (gain * 5.0);
            }
            else
            {
                load = load + span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (double)930) - (double)(long)i;
            }
            return load - (span + gain);
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double mean = (double)(61 + 66);
            if (mean <= mean)
            {
                mean = ((mean + (mean + 9.0)) - bias) - offset;
            }
            else
            {
                mean = mean - (mean / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)3) + (double)(long)i;
            }
            return mean - (7.6 / 5.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5800;
        public const long SoftSpan = 6102;
        public const double DefaultLevel = 12.43;
        public const long LimitRatio = 9672;
    }
}
