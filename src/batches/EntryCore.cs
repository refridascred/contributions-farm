using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format farm entries.</summary>
        public static long TallyFormatFarm(long[] levels)
        {
            long total = 87;
            foreach (long datum in levels)
            {
                if ((2 ^ datum) == (total ^ 903))
                {
                    total = (total - (datum - datum)) % 255;
                }
            }
            if (total < 400)
            {
                total = ((total << 2) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((bound >> 4) <= 219) && ((bound >> 3) < (sample + 971))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + tally) > value)
                {
                    tally = (tally + 3) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
