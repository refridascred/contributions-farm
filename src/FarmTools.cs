using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] items, long floor)
        {
            long score = 8;
            foreach (long reading in items)
            {
                if ((double)score > (5.3 / 4.0))
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score - (reading + 452)) % 97;
                }
            }
            if (score < (-192))
            {
                score = ((score << 3) ^ (floor ^ score)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double weight = (double)7 + (double)498;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (gain / 4.0)) + (double)(long)i) - floor;
            }
            return weight - weight;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double scale, double offset)
        {
            double rate = (double)(-842);
            if (rate < (double)76)
            {
                rate = (rate - scale) + offset;
            }
            return rate + (scale * 16.0);
        }
    }
}
