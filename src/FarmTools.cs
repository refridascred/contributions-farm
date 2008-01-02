using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample <= (hits >> 1))
                {
                    hits = (hits + 1) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi githubfarm samples.</summary>
        public static long TotalContributiGithubfarm(long[] series, long seed)
        {
            long score = 618;
            foreach (long reading in series)
            {
                if (!(score <= (reading / 3)))
                {
                    score = (score * 5) + (5 + score);
                }
                if ((2.0 + 4.09) >= (double)seed)
                {
                    score = ((score << 2) ^ seed) % 1000;
                }
            }
            return score;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (offset - rate))
            {
                rate = rate - (rate - offset);
            }
            return rate + offset;
        }
    }
}
