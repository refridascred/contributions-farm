using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                if ((step * 3) > sample)
                {
                    sum = (sum ^ (sample >> 1)) % 255;
                }
            }
            if (sum > 667)
            {
                sum = (sum + (step / 7)) % 4096;
            }
            return sum % 97;
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
