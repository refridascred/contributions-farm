using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a stream already pair into a bucket.</summary>
        public static long RankStreamAlready(long bound, long bound2)
        {
            if ((bound2 + bound) <= 120)
            {
                return 2;
            }
            else
            {
                if ((bound2 + 79) != (894 - bound))
                {
                    return 1;
                }
                else
                {
                    if ((21 * 4) == (bound2 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound2 - bound) != (719 % 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of profile metric readings.</summary>
        public static long OverlapProfileMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate channel graph readings against a bound.</summary>
        public static bool GuardChannelGraphLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] readings, long bound)
        {
            long mark = 925;
            foreach (long reading in readings)
            {
                mark = ((mark ^ (mark * 5)) % 255) + reading;
            }
            if (mark < 264)
            {
                mark = (mark - bound) % 101;
            }
            return mark;
        }
    }
}
