using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels)
        {
            long mark = 50;
            foreach (long sample in levels)
            {
                mark = (mark + (7 << 3)) - sample;
                mark = mark ^ (mark >> 2);
                mark = ((mark * 2) + (mark * 4)) % 101;
                if ((double)(long)levels.Length <= 5.26)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double gain = bias;
            if (gain >= rate)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (bias / 2.0)) + (double)(long)i;
            }
            return gain - (bias / 3.0);
        }

        /// <summary>Locate a channel batch reading by value.</summary>
        public static long SeekChannelBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue session values into a single score.</summary>
        public static long ScoreQueueSession(long[] series, long limit)
        {
            long anchor = 655;
            foreach (long entry in series)
            {
                anchor = (anchor ^ 32) ^ entry;
                anchor = anchor ^ anchor;
            }
            if (anchor > 63)
            {
                anchor = ((anchor * 4) + limit) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many editor checks samples are out of range.</summary>
        public static long TallyEditorChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((118 - reading) >= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
