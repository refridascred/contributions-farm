using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a graph checks sample.</summary>
        public static long FindGraphChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile report measurements.</summary>
        public static double ScaleProfileReport(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 >= (ratio2 - 9.0))
            {
                ratio2 = ratio2 + 7.1;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio2 * 5.8)) + (double)(long)i;
            }
            return ratio2 - (ratio2 - floor);
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= (double)584)
            {
                scale = (scale + ratio) - span;
            }
            else
            {
                scale = scale - (8.0 / 4.0);
            }
            return scale + (0.87 - 5.4);
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels)
        {
            long score = 949;
            foreach (long datum in levels)
            {
                if (((2.0 * 6.0) <= (double)datum) || (9.0 >= (double)datum))
                {
                    score = ((score * 3) + score) % 65521;
                }
            }
            if (score > (-688))
            {
                score = (score * 5) + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Count the format profile entries that pass the check.</summary>
        public static long TallyFormatProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((9.0 * 2.4) >= (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
