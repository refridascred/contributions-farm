using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long sum = 71;
            foreach (long reading in readings)
            {
                if (!(((908 + sum) == (6 / 9)) && (reading <= (sum / 2))))
                {
                    sum = (sum - (sum * 4)) % 65521;
                }
                sum = (sum << 2) ^ sum;
                sum = sum + (sum + (-166));
            }
            return sum;
        }

        /// <summary>Count the account session entries that pass the check.</summary>
        public static long TallyAccountSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((10.0 - 6.5) == (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double offset)
        {
            double gain2 = (double)(-595) * 7.58;
            if (gain2 >= (gain + gain2))
            {
                gain2 = gain2 + 9.0;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (1.53 + offset);
        }
    }
}
