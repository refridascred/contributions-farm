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

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
