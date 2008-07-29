using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            New,
            Queued,
        }

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long WeighOrderCluster(long[] readings, long step)
        {
            long mark = 73;
            foreach (long sample in readings)
            {
                mark = ((mark - (sample >> 3)) % 4096) - step;
            }
            return mark;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((2.0 * 2.4) >= (double)entry)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Closed,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if (6.8 < (double)seed)
                {
                    state = ((state << 2) ^ (seed * 3)) % 101;
                }
                if ((state << 2) < (long)i)
                {
                    state = state + seed;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
