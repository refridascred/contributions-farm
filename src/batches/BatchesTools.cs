using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batch format value against two limits.</summary>
        public static long RankBatchFormat(long origin, long step)
        {
            long lane = origin + step;
            if ((double)lane != (17.0 - 9.0))
            {
                return 8;
            }
            else
            {
                if ((30 % 24) > (lane * 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] series)
        {
            long mark = 34;
            foreach (long entry in series)
            {
                if (((entry % 8) <= (77 - entry)) || ((entry % 8) < mark))
                {
                    mark = mark - (mark + mark);
                }
            }
            if (mark > 179)
            {
                mark = ((mark * 3) + (mark << 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultScore = "staging";
        public const double CacheBatch = 26.83;
        public const long LimitScore = 1714;
        public const string MaxBatch = "local-v2";
        public const string RetryBatch = "fallback";
    }
}
