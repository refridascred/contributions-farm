using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels, long step)
        {
            long anchor = 60;
            foreach (long item in levels)
            {
                anchor = (anchor + item) + step;
            }
            if (anchor > 5)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
