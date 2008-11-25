using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double weight, double offset)
        {
            double ratio = 9.84 * 7.9;
            if (ratio <= offset)
            {
                ratio = ratio - 1.0;
            }
            else
            {
                ratio = ratio - (double)40;
            }
            return ratio + (weight + offset);
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell > (cell ^ cell)) || ((cell + 473) == (cell + cell))) || (3 > (cell + 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long origin, long origin2)
        {
            if ((origin - origin2) >= (origin * 2))
            {
                return 0;
            }
            else
            {
                if (origin2 <= (origin2 ^ origin2))
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin2 != (double)38))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((63 << 3) == (origin2 + origin2))
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
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Draft,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double drift = rate;
            if (drift > (drift / 7.0))
            {
                drift = (drift - (rate + drift)) - offset;
            }
            return drift + (double)88;
        }
    }
}
