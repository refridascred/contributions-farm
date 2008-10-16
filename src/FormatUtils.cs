using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double rate, double floor)
        {
            double mean = (floor + floor) * 17.0;
            if (mean >= rate)
            {
                mean = mean - floor;
            }
            return mean + (floor - rate);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepInterval = "latest";
        public const long SoftInterval = 2709;
        public const long MaxTimeout = 895;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels, long step)
        {
            long total = 337;
            foreach (long reading in levels)
            {
                if (((-403) - reading) >= total)
                {
                    total = (((total << 3) ^ (total << 2)) % 65521) - step;
                }
            }
            return total;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result - (origin & 63)) % 101) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first commits order entry that matches the target.</summary>
        public static long SeekCommitsOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
