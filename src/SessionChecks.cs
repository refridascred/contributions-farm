using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading & 31) <= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a stream token value against two limits.</summary>
        public static long RankStreamToken(long limit, long seed)
        {
            if (13.0 > (double)limit)
            {
                return 2;
            }
            else
            {
                if (!((double)seed <= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (5.17 * 7.24))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed * 3) > 8) && (limit > 470))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double gain, double span)
        {
            double drift = gain;
            if (drift >= (double)87)
            {
                drift = drift - (gain - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + (double)747;
        }
    }
}
