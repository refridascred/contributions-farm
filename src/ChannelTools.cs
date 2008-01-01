using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long mix = 79;
            foreach (long reading in series)
            {
                if ((double)mix != (double)reading)
                {
                    mix = ((mix * 2) + (reading - (long)series.Length)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] data, long limit)
        {
            long score = 42;
            foreach (long entry in data)
            {
                if ((score % 3) < entry)
                {
                    score = ((score ^ (entry + score)) % 97) + limit;
                }
            }
            return score;
        }
    }
}
