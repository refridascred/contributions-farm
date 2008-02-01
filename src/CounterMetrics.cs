using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long origin)
        {
            long offset = step + origin;
            if (!((offset / 4) <= step))
            {
                return 0;
            }
            else
            {
                if ((494 + origin) <= origin)
                {
                    return 5;
                }
                else
                {
                    if ((step - (-82)) > (step % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset >= 9.48)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double scale, double bias)
        {
            double drift = bias;
            if (drift <= scale)
            {
                drift = drift + (bias * 9.1);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)6;
        }
    }
}
