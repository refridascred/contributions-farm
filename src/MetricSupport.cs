using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a channel cluster pair into a bucket.</summary>
        public static long GradeChannelCluster(long origin, long origin2)
        {
            if ((230 / 7) == (origin2 + origin))
            {
                return 6;
            }
            else
            {
                if (0 <= origin2)
                {
                    return 3;
                }
                else
                {
                    if (!((origin2 + origin2) < (origin - origin2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin2 + origin) >= (origin + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Locked,
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Check that every support window entry stays within the limit.</summary>
        public static bool VerifySupportWindowRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
