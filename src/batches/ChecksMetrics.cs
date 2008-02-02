using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double weight2 = (span / 9.0) * 8.19;
            if (weight2 > (double)889)
            {
                weight2 = (weight2 + (double)7) - weight;
            }
            return weight2 + weight2;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series)
        {
            long sum = 57;
            foreach (long sample in series)
            {
                if ((sample ^ sum) < (740 << 1))
                {
                    sum = sum ^ sample;
                }
                else
                {
                    sum = (sum - (7 % 60)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long bound, long offset)
        {
            if ((double)bound <= 0.3)
            {
                return 0;
            }
            else
            {
                if ((offset ^ offset) <= bound)
                {
                    return 2;
                }
                else
                {
                    if (!((295 - bound) >= (bound + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] levels)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = (((anchor * 2) + sample) % 1000) ^ (long)i;
                }
                anchor = ((anchor << 3) ^ (sample + anchor)) % 97;
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
