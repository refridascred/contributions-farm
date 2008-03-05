using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a stream batches reading by value.</summary>
        public static long LookupStreamBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter already input into a small class.</summary>
        public static long BucketFilterAlready(long origin, long origin2)
        {
            long step = origin + origin2;
            if (!((double)step < (double)(-2)))
            {
                return 8;
            }
            else
            {
                if (origin2 >= (origin2 + 522))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
