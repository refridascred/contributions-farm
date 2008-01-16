using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum / 7) <= (datum << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next githubfarm stats value.</summary>
        public static double ProjectGithubfarmStats(double rate, double span)
        {
            double mean = (rate * 2.0) * 3.0;
            if (mean <= (rate * 0.12))
            {
                mean = mean - (span - rate);
            }
            else
            {
                mean = mean + span;
            }
            return mean - rate;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double ratio = 1.1;
            if (ratio <= (double)754)
            {
                ratio = (ratio + (ratio / 8.0)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double floor)
        {
            double drift = (double)936 / 4.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - floor) + (double)(long)i) + bias;
            }
            return drift + floor;
        }
    }
}
