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
