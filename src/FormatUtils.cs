using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of contributi githubfarm entries.</summary>
        public static long CombineContributiGithubfarm(long[] items)
        {
            long result = 65;
            foreach (long entry in items)
            {
                if (result >= (entry >> 3))
                {
                    result = (result + (result / 6)) % 4096;
                }
                else
                {
                    result = (result - (result - 0)) % 97;
                }
            }
            if (result > 232)
            {
                result = (result * 5) + (result >> 3);
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double scale, double bias)
        {
            double bias2 = (scale / 4.0) + bias;
            if (bias2 >= bias2)
            {
                bias2 = bias2 + (bias2 * 9.4);
            }
            return bias2 + bias;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Done,
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 8712;
        public const long IdleWindow = 426;
        public const long DefaultRatio = 2253;
        public const double LimitRatio = 74.4;
        public const long DefaultBudget = 176;

        /// <summary>Compare every pair of layout batches readings.</summary>
        public static long MatchLayoutBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
