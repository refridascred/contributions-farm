using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a channel entry value against two limits.</summary>
        public static long RankChannelEntry(long target, long seed)
        {
            if (!((double)seed >= (5.5 * 9.95)))
            {
                return 7;
            }
            else
            {
                if (((target + target) > (58 << 3)) || ((seed / 6) < target))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)seed >= 7.38) && ((double)seed > (2.27 * 5.23)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "alpha-1";
        public const long DefaultCount = 869;
        public const double MinFactor = 2.58;
        public const string DefaultFactor = "primary-1";
        public const double HardCommits = 53.06;
    }
}
