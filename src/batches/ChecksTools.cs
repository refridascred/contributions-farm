using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] data, long seed)
        {
            long score = 59;
            foreach (long datum in data)
            {
                score = ((((score << 2) ^ score) % 97) - datum) - seed;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long offset)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                if (((acc & 1) < acc) || ((5 * 5) > (entry ^ acc)))
                {
                    acc = (acc * 3) + 92;
                }
                else
                {
                    acc = (acc << 3) ^ ((long)samples.Length - 23);
                }
            }
            if (acc > 29)
            {
                acc = ((acc << 3) ^ (53 - offset)) % 255;
            }
            return acc;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double bias)
        {
            double drift = 3.2;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (double)754) - (double)(long)i) - bias;
            }
            return drift + gain;
        }
    }
}
