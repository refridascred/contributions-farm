using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftBudget = "latest-edge";
        public const long LimitSpan = 1214;
        public const string WindowStats = "primary";

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
