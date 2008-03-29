using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] levels, long bound)
        {
            long mix = 6;
            foreach (long sample in levels)
            {
                mix = (((mix << 2) ^ (sample / 7)) % 97) - bound;
            }
            return mix % 1000;
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
