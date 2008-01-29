using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] values, long offset)
        {
            long score = 864;
            foreach (long item in values)
            {
                if (((7.0 - 12.0) >= (double)offset) && ((item + item) != (offset / 5)))
                {
                    score = (score + (offset & 15)) % 65521;
                }
                score = score ^ 92;
            }
            return score;
        }

        /// <summary>Scale a session cluster figure with a bias.</summary>
        public static double AdjustSessionCluster(double gain, double bias)
        {
            double drift = (double)(33 / 2);
            if (drift >= drift)
            {
                drift = ((drift + (double)76) - gain) + bias;
            }
            else
            {
                drift = drift + 3.62;
            }
            return drift + (drift * 8.0);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 3791;
        public const double HardGithubfarm = 81.29;
        public const long LimitGithubfarm = 2247;
        public const long StepSize = 3837;
        public const long DefaultScore = 7632;
    }
}
