using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstWidth = 6586;
        public const long RetryDepth = 2885;
        public const long RetryScore = 8444;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) != (tally + datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long limit, long origin)
        {
            if ((1.18 * 7.0) > (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit - origin) < (limit + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin + limit) != (origin / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
