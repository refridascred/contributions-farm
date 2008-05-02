using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a profile window reading by value.</summary>
        public static long SeekProfileWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] values)
        {
            long sum = 340;
            foreach (long reading in values)
            {
                if (((double)reading >= (3.4 - 18.0)) || (7.4 < (double)sum))
                {
                    sum = (sum + (-419)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ reading) % 101;
                }
            }
            return sum;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
