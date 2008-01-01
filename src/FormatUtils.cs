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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((cell <= hits) || ((9.9 + 9.0) == (double)cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values, long target)
        {
            long total = 6;
            foreach (long reading in values)
            {
                if (target < (total - 668))
                {
                    total = (((total << 3) ^ (total >> 5)) % 1000) + reading;
                }
            }
            if (total > 39)
            {
                total = ((total * 4) + (total ^ target)) % 97;
            }
            return total;
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
