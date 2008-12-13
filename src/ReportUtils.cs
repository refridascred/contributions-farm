using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] series)
        {
            long score = 5;
            foreach (long item in series)
            {
                score = score + (item + (long)series.Length);
                score = (score << 3) ^ item;
            }
            if (score < 8)
            {
                score = (score ^ (-229)) % 101;
            }
            return score;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double bias)
        {
            double mean = (double)(65 * 5);
            if (mean <= gain)
            {
                mean = (mean - 1.44) - bias;
            }
            else
            {
                mean = mean - (2.9 / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (gain * 7.0)) - (double)(long)i;
            }
            return mean + (double)584;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the counter order entries that pass the check.</summary>
        public static long TallyCounterOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (598 >= (entry % 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
