using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Closed,
            Retry,
        }

        /// <summary>Rank commits counter input into a small class.</summary>
        public static long RankCommitsCounter(long step, long bound)
        {
            if ((bound + step) <= step)
            {
                return 5;
            }
            else
            {
                if ((step > (step >> 5)) || ((bound << 3) >= (bound * 3)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                double load = (double)seed * 4.72;
                if (!(total <= (seed + seed)))
                {
                    total = (total << 2) ^ (seed / 5);
                }
                if (((long)i < seed) && ((load + load) <= load))
                {
                    load = load - load;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
