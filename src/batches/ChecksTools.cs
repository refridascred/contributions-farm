using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSpan = 5078;
        public const long DefaultInterval = 6681;
        public const double BurstTimeout = 35.26;

        /// <summary>Classify a batches route pair into a bucket.</summary>
        public static long RankBatchesRoute(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (floor >= (floor ^ limit))
            {
                return 7;
            }
            else
            {
                if ((diff * 2) >= (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if ((diff >> 2) != (limit % 24))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit >= (diff % 64))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
