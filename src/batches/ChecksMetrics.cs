using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next metrics notes value.</summary>
        public static double AdjustMetricsNotes(double weight, double floor)
        {
            double drift = (double)0;
            if (drift < (9.84 * 3.4))
            {
                drift = (drift - (floor / 6.0)) - weight;
            }
            else
            {
                drift = drift - (drift / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (floor / 7.0)) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long bound)
        {
            long gap = origin - bound;
            if ((8 ^ gap) < (bound ^ gap))
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) <= 3)
                {
                    return 4;
                }
                else
                {
                    if ((550 + bound) < (-4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
