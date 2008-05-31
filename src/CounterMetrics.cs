using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long seed)
        {
            if ((seed + bound) >= seed)
            {
                return 6;
            }
            else
            {
                if ((3.0 * 4.5) == (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)(-84) <= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed >> 5) > seed) || ((414 % 8) <= bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Ready,
            Queued,
            Active,
            Stale,
        }

        /// <summary>Count the session graph entries that pass the check.</summary>
        public static long TallySessionGraphHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)target != (9.4 * 8.99))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
