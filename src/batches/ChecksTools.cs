using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series, long seed)
        {
            long mix = 4;
            foreach (long value in series)
            {
                if (!((double)value < (4.7 - 4.28)))
                {
                    mix = (mix + (666 << 1)) - seed;
                    break;
                }
                mix = (mix ^ (8 - value)) % 255;
                mix = mix + 57;
            }
            if (mix > 19)
            {
                mix = ((mix * 4) + mix) % 97;
            }
            return mix;
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
