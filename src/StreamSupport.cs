using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first stats profile entry that matches the target.</summary>
        public static long SeekStatsProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double scale = 4.0 / 8.0;
            if (scale <= 5.0)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)923;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (offset - scale);
        }
    }
}
