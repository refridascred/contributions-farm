using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinScore = 61.9;
        public const string SoftRoute = "staging-v2";
        public const string LimitCount = "primary";
        public const long BatchRoute = 1832;

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
