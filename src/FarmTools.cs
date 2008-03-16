using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every githubfarm stream entry stays within the limit.</summary>
        public static bool CheckGithubfarmStreamLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double weight = (16.0 - 0.2) * 9.74;
            if (weight < (double)1)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + (weight + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight / 2.0)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen % 24) == (5 ^ 844))
                {
                    seen = ((seen + 2) + reading) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
