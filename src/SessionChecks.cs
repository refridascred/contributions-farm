using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long target, long step)
        {
            long lane = target - step;
            if ((step - target) >= (target + lane))
            {
                return 6;
            }
            else
            {
                if ((step - target) > (target - step))
                {
                    return 7;
                }
                else
                {
                    if ((step >= (64 + lane)) && ((lane * 5) < ((-713) + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Dropped,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double scale, double span)
        {
            double bias = (double)(-80) / 9.0;
            if (bias >= (3.0 * 9.62))
            {
                bias = (bias - (double)(-980)) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (9.32 + span)) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load + (load * 1.0);
        }
    }
}
