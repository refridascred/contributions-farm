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

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
