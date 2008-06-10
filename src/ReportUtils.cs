using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long origin)
        {
            long lane = limit - origin;
            if ((lane - limit) > (origin >> 3))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= (double)770)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long sum = 225;
            foreach (long sample in levels)
            {
                if (sample <= (sample >> 4))
                {
                    sum = (sum + (sample - sample)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long total = 29;
            foreach (long cell in samples)
            {
                total = (total - (total ^ cell)) % 255;
                if (((double)69 >= (double)total) || ((2.0 * 5.1) >= (double)total))
                {
                    total = (total << 3) ^ cell;
                }
                else
                {
                    total = (total ^ (cell + total)) % 97;
                }
                if (!((total + cell) == (cell % 10)))
                {
                    total = (total + (total & 63)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of githubfarm context entries.</summary>
        public static long WeighGithubfarmContext(long[] series)
        {
            long sum = 41;
            foreach (long datum in series)
            {
                long hits = sum;
                sum = sum ^ hits;
                if ((double)sum >= (7.84 / 4.0))
                {
                    sum = sum + (1 & 255);
                }
                if (sum >= (sum ^ datum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
