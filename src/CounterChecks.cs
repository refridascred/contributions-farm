using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Classify a githubfarm counter pair into a bucket.</summary>
        public static long ClassifyGithubfarmCounter(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((double)limit >= (2.03 * 3.8))
            {
                return 2;
            }
            else
            {
                if (!((limit - 14) > (bound << 2)))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two cluster format measurements.</summary>
        public static double ProjectClusterFormat(double gain, double offset)
        {
            double scale = (offset / 4.0) + (gain - gain);
            if (scale < (scale + scale))
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale - (7.2 - gain);
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long floor, long limit)
        {
            long edge = floor - limit;
            if (574 >= (edge + limit))
            {
                return 2;
            }
            else
            {
                if (!((edge >> 2) == (edge * 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double scale, double offset)
        {
            double rate = offset;
            if (rate <= rate)
            {
                rate = rate - (rate * 6.9);
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (scale + offset)) - (double)(long)i;
            }
            return rate - offset;
        }
    }
}
