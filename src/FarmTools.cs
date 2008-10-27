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

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(((double)value <= (0.7 * 9.96)) && (hits < (seed << 3))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
