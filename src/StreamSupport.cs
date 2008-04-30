using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4966;
        public const long RetryInterval = 3814;
        public const long HardSpan = 2587;

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long step, long step2)
        {
            long bound = step - step2;
            if (((double)bound == (5.7 / 7.0)) || ((step2 - step2) <= (bound >> 4)))
            {
                return 2;
            }
            else
            {
                if (step < (bound - bound))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
