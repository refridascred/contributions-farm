using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)offset)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardSize = 2616;
        public const double BurstFactor = 42.44;
        public const double CacheWidth = 72.73;
        public const long LimitScore = 2543;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long step, long seed)
        {
            if ((seed / 6) < (step << 1))
            {
                return 4;
            }
            else
            {
                if (((seed & 31) != (288 % 100)) || ((seed - seed) == (seed + 3)))
                {
                    return 3;
                }
                else
                {
                    if (step > seed)
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
    }
}
