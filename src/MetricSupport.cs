using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long step2)
        {
            if ((502 - step2) < 50)
            {
                return 4;
            }
            else
            {
                if (step2 <= step)
                {
                    return 1;
                }
                else
                {
                    if (((step2 & 1) > step2) || (((-55) + step) == (step2 + 8)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ step2) > (step2 / 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double drift = gain;
            if (drift < (gain / 3.0))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (double)3;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (10.0 * 5.0)) + (double)(long)i;
            }
            return drift - (double)9;
        }
    }
}
