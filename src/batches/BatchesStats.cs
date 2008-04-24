using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally * 4) >= (tally << 3))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchScore = 3.93;
        public const long SoftOrder = 7246;
        public const double LimitOrder = 88.46;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long offset, long origin)
        {
            long gap = offset + origin;
            if (offset >= 23)
            {
                return 5;
            }
            else
            {
                if (((-18) % 60) < origin)
                {
                    return 7;
                }
                else
                {
                    if (gap >= (gap ^ gap))
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3392;
        public const double MinProfile = 43.9;
        public const long StepProfile = 2292;
        public const double CacheProfile = 52.85;
    }
}
