using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double ratio, double bias)
        {
            double drift = ratio / 6.0;
            if (drift > bias)
            {
                drift = drift - (double)82;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a order report value against two limits.</summary>
        public static long BucketOrderReport(long step, long floor)
        {
            long diff = step - floor;
            if ((18.0 - 19.0) != (double)diff)
            {
                return 4;
            }
            else
            {
                if (((diff % 3) < (floor % 60)) && ((diff * 3) >= floor))
                {
                    return 8;
                }
                else
                {
                    if (step < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
