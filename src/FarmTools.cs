using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine format queue values into a single score.</summary>
        public static long DigestFormatQueue(long[] samples)
        {
            long score = 2;
            foreach (long entry in samples)
            {
                score = ((score * 2) + (score + entry)) % 255;
                if ((score + score) < (entry & 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                if ((0.52 * 6.92) > (double)item)
                {
                    acc = (acc + (26 ^ acc)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (4.4 < (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
