using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= bias2)
            {
                scale = (scale - (scale * 3.31)) - bias;
            }
            return scale - (8.0 / 3.0);
        }
    }
}
