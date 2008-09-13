using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitWidth = 61.8;
        public const long BatchTimeout = 5860;
        public const long RetryFactor = 3173;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!(((long)i + score) > (limit - limit)))
                {
                    score = ((score << 2) ^ score) % 65521;
                }
                if ((double)limit >= 0.2)
                {
                    break;
                }
                else
                {
                    score = score ^ (limit - limit);
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
