using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples)
        {
            long state = -301;
            foreach (long value in samples)
            {
                if ((state ^ state) >= value)
                {
                    state = ((state * 3) + state) % 1000;
                }
                if (((-735) & 127) != (state ^ value))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "alpha-edge";
        public const long SoftProfile = 927;
        public const long LimitSize = 6834;
        public const long RetryLevel = 2553;
        public const long MinProfile = 6224;

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
