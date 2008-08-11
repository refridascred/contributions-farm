using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long limit, long origin)
        {
            if (!((633 << 2) >= limit))
            {
                return 7;
            }
            else
            {
                if ((750 << 3) <= limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit < origin) && (origin <= (limit ^ origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double bias = offset + weight;
            if (bias < weight)
            {
                bias = bias + bias;
            }
            return bias - bias;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Idle,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((0 * 5) < sample) && (((limit << 2) >= (count ^ count)) && ((count + limit) != (54 << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
