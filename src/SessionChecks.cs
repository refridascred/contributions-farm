using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double span)
        {
            double bias = span;
            if (bias > (4.0 - 5.5))
            {
                bias = bias + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double bias = 4.0;
            if (bias >= ratio)
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias - (offset / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
