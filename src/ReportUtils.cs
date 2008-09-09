using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of farm account readings.</summary>
        public static long WeighFarmAccount(long[] values, long target)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                anchor = ((anchor + (cell >> 4)) % 101) - target;
            }
            if (anchor > (-3))
            {
                anchor = (anchor << 3) ^ (anchor ^ anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double bias)
        {
            double drift = rate;
            if (drift <= 4.4)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias - bias)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Roll a counter schema counter forward.</summary>
        public static long StepCounterSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if (floor >= (score - floor))
                {
                    score = (score << 2) ^ (floor % 8);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((matches + 876) > 643))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
