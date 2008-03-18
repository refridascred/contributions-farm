using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next session cache value.</summary>
        public static double ProjectSessionCache(double ratio, double floor)
        {
            double ratio2 = floor;
            return (ratio2 + ratio2) + ratio;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = weight;
            if (ratio >= (ratio - 6.0))
            {
                ratio = (ratio + (double)311) + span;
            }
            return ratio + weight;
        }
    }
}
