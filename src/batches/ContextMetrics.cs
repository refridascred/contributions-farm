using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(((seen + (long)readings.Length) > (seen / 6)) || ((seen << 1) >= (reading >> 4))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double bias, double floor)
        {
            double rate = (floor - 9.24) / 4.0;
            return (rate + (double)(-395)) + bias;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Done,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long seed, long floor)
        {
            if (!((floor + seed) <= (seed ^ floor)))
            {
                return 4;
            }
            else
            {
                if ((155 / 5) > (208 + floor))
                {
                    return 6;
                }
                else
                {
                    if (!(30 >= (seed - seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
