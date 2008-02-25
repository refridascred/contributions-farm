using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema layout measurements.</summary>
        public static double ScaleSchemaLayout(double ratio, double bias)
        {
            double rate = bias;
            if (rate < (bias * 5.0))
            {
                rate = rate + (double)9;
            }
            return rate - ratio;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value > (step << 2)) || ((2.2 / 7.0) >= (double)step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long floor)
        {
            long slot = bound - floor;
            if (((bound + floor) >= (floor << 1)) || ((bound + slot) >= floor))
            {
                return 6;
            }
            else
            {
                if ((double)floor < (17.0 / 5.0))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
