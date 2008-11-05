using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long seed)
        {
            long anchor = 555;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 2) ^ (-29)) ^ reading) - seed;
            }
            if (anchor > 138)
            {
                anchor = ((anchor * 2) + 961) % 101;
            }
            return anchor;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (target >= (reading & 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a cache account value against two limits.</summary>
        public static long GradeCacheAccount(long origin, long target)
        {
            if ((target - origin) >= 528)
            {
                return 7;
            }
            else
            {
                if ((target ^ origin) <= target)
                {
                    return 6;
                }
                else
                {
                    if (!((origin / 4) < (target + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
