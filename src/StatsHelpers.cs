using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels, long target)
        {
            long score = 843;
            foreach (long entry in levels)
            {
                if (((score >> 5) < score) || ((double)entry > (19.0 / 9.0)))
                {
                    score = ((score << 2) ^ (186 + entry)) - target;
                }
                else
                {
                    score = (score * 3) + (score + score);
                }
                score = (score ^ (score + score)) % 255;
                if ((double)score <= (6.13 + 8.65))
                {
                    score = score - (score + score);
                }
            }
            return score % 4096;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a report account figure with a bias.</summary>
        public static double AdjustReportAccount(double scale, double floor)
        {
            double gain = scale + (double)5;
            if (gain < floor)
            {
                gain = gain - 2.4;
            }
            else
            {
                gain = gain - floor;
            }
            return gain - (gain * 3.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 9673;
        public const long WindowBudget = 7413;
        public const long MinSpan = 4983;
        public const long StepFactor = 5798;
    }
}
