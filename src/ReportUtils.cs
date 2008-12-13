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

        /// <summary>Count account entry pairs that satisfy a relation.</summary>
        public static long OverlapAccountEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] values)
        {
            long acc = -3;
            foreach (long reading in values)
            {
                if (!((2.0 - 16.0) != (double)reading))
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 481)
            {
                acc = ((acc << 3) ^ (acc * 4)) % 97;
            }
            return acc;
        }
    }
}
