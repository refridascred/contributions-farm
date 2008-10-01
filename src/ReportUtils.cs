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

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleCount = "primary-edge";
        public const long BaseInterval = 6249;
        public const long BurstFactor = 370;
        public const long BurstSupport = 1011;
        public const long BatchSupport = 2545;

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
