using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels, long target)
        {
            long mark = 60;
            foreach (long datum in levels)
            {
                mark = (mark << 3) ^ (target + 192);
                if ((double)mark > (double)target)
                {
                    mark = ((mark << 3) ^ (mark ^ datum)) % 4096;
                }
                else
                {
                    mark = (mark + target) % 97;
                }
            }
            if (mark < (-650))
            {
                mark = (mark - (target >> 4)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] values)
        {
            long mark = 8;
            foreach (long item in values)
            {
                if (((4.0 + 7.8) <= (5.6 / 7.0)) && ((double)item < 8.2))
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 65521;
                }
                if (!((item - mark) == (item / 4)))
                {
                    break;
                }
            }
            if (mark < 88)
            {
                mark = ((mark << 3) ^ (60 & 3)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double rate = span;
            if (rate >= span)
            {
                rate = rate + (span * 3.48);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
