using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long sum = 7;
            foreach (long item in items)
            {
                sum = ((sum + (bound - bound)) % 1000) - item;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 8551;
        public const double DefaultBuffer = 3.2;
        public const long WindowBuffer = 8113;
        public const string LimitBuffer = "legacy-v2";
        public const string BaseSpan = "standard-1";

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Size { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long ScoreAlreadyGithubfarm(long[] levels, long origin)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((19.0 - 4.9) == (double)origin)
                {
                    sum = (sum ^ ((long)levels.Length + reading)) % 4096;
                }
                else
                {
                    sum = (sum << 2) ^ reading;
                }
            }
            if (sum < 2)
            {
                sum = (sum ^ (5 - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double bias = (double)(988 ^ 11);
            return ((bias + bias) + ratio) + floor;
        }
    }
}
