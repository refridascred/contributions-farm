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

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double mean = (double)(92 << 1);
            return ((mean + mean) + gain) + span;
        }

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
