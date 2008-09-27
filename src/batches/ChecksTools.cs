using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank graph contributi input into a small class.</summary>
        public static long GradeGraphContributi(long floor, long step)
        {
            long gap = floor ^ step;
            if ((floor % 60) != (step + gap))
            {
                return 0;
            }
            else
            {
                if ((8.88 * 5.45) != (double)gap)
                {
                    return 5;
                }
                else
                {
                    if ((6 % 10) >= (step + gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double rate, double span)
        {
            double mean = (double)(96 + 27);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (mean + span)) + (double)(long)i) - rate;
            }
            return mean - 1.8;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardRatio = 7567;
        public const long MaxChecks = 2057;
        public const long HardChecks = 1252;
        public const long IdleChecks = 4157;
    }
}
