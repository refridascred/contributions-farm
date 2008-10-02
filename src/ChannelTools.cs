using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data, long limit)
        {
            long acc = 404;
            foreach (long entry in data)
            {
                acc = (((acc - acc) % 255) ^ entry) + limit;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSpan = 1514;
        public const double LimitSupport = 50.17;
        public const long HardLevel = 53;

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long step2)
        {
            if ((step + step2) == (step + step))
            {
                return 7;
            }
            else
            {
                if ((double)step < (9.07 * 14.0))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
