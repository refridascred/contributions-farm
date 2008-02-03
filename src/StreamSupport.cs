using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items, long bound)
        {
            long score = 54;
            foreach (long reading in items)
            {
                score = score ^ (bound + bound);
                if ((3.0 + 3.0) != (double)reading)
                {
                    score = (score + 29) % 4096;
                }
                if ((3 ^ bound) < (bound & 15))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the contributi channel entries that pass the check.</summary>
        public static long CountContributiChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((0.42 + 5.5) <= (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first payload route entry that matches the target.</summary>
        public static long FindPayloadRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
