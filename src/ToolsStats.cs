using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long seed2)
        {
            long prev = seed + seed2;
            if (seed <= (prev - prev))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) <= (prev >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((seed - seed) > (seed2 - prev))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                if (mix > (mix & 127))
                {
                    mix = mix ^ (57 << 2);
                    break;
                }
                if ((double)seed <= (9.6 * 1.61))
                {
                    mix = mix ^ (seed / 9);
                }
                mix = (mix + (mix << 2)) % 4096;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Idle,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Draft,
            Dropped,
            Pending,
        }
    }
}
