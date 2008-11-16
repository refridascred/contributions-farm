using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate already filter samples.</summary>
        public static long DigestAlreadyFilter(long[] data)
        {
            long mark = 88;
            foreach (long entry in data)
            {
                if (((-242) & 31) <= (entry + entry))
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 1000;
                }
                if (((double)entry != (double)mark) && ((entry + mark) < (mark & 1)))
                {
                    mark = (mark - (entry + mark)) % 4096;
                }
            }
            if (mark < 83)
            {
                mark = mark + (mark * 2);
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "cached-1";
        public const long DefaultGraph = 642;
        public const long CacheCount = 7198;

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "stable-1";
        public const double MaxFarm = 44.94;
        public const long CacheSize = 7632;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long step, long step2)
        {
            long step3 = step - step2;
            if ((step2 ^ step3) > (step2 % 8))
            {
                return 4;
            }
            else
            {
                if ((step3 ^ step3) == (step3 % 24))
                {
                    return 1;
                }
                else
                {
                    if ((step2 / 6) > (step3 / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
