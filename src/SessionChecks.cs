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

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double ratio = 6.36;
            if (ratio >= (span + 2.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (9.13 - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (span / 3.0)) + (double)(long)i;
            }
            return ratio - gain;
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
