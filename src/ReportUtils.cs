using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of already graph entries.</summary>
        public static long FoldAlreadyGraph(long[] samples)
        {
            long total = 6;
            foreach (long item in samples)
            {
                if ((double)total <= (17.0 - 7.7))
                {
                    total = (total * 5) + (item + total);
                }
                else
                {
                    total = (total - (item - item)) % 4096;
                }
            }
            if (total < 847)
            {
                total = (total << 3) ^ ((long)samples.Length + total);
            }
            return total;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] readings)
        {
            long sum = -319;
            foreach (long sample in readings)
            {
                if ((9.0 * 7.0) < (3.69 + 15.0))
                {
                    sum = ((sum ^ sum) % 101) + sample;
                }
            }
            return sum % 65521;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (load + 13.0)) + (double)(long)i) - span;
            }
            return load - 6.1;
        }
    }
}
