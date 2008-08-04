using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double scale, double bias)
        {
            double load = (double)48 + 0.4;
            if (load >= 8.0)
            {
                load = load - bias;
            }
            else
            {
                load = load - scale;
            }
            return load - (8.27 + load);
        }

        /// <summary>Roll a schema githubfarm counter forward.</summary>
        public static long StepSchemaGithubfarm(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = (score + step) % 97;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many account stats samples are out of range.</summary>
        public static long CountAccountStatsGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((5.27 * 8.0) < (double)floor))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
