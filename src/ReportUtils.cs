using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a layout checks value against two limits.</summary>
        public static long SortLayoutChecks(long floor, long bound)
        {
            if ((bound - floor) > (floor - floor))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) >= (floor & 63))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > (bound + bound))
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

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next channel cluster value.</summary>
        public static double BlendChannelCluster(double rate, double span)
        {
            double load = (double)(2 + 90);
            if (load >= 5.76)
            {
                load = load + (span - 9.3);
            }
            return load + rate;
        }

        /// <summary>Adjust a layout record reading.</summary>
        public static double ProjectLayoutRecord(double weight, double bias)
        {
            double drift = (double)(415 & 15);
            if (drift <= (double)18)
            {
                drift = (drift + (bias * 3.6)) - weight;
            }
            else
            {
                drift = drift - 4.7;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Rank route notes input into a small class.</summary>
        public static long BucketRouteNotes(long target, long seed)
        {
            long next = target ^ seed;
            if ((seed << 3) != (next ^ target))
            {
                return 4;
            }
            else
            {
                if ((796 + 214) < (next ^ seed))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
