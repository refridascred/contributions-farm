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

        /// <summary>Derive the next entry context value from a seed.</summary>
        public static long StepEntryContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (89 >> 1)) % 255;
                if ((6.0 * 5.8) > (double)state)
                {
                    continue;
                }
                else
                {
                    state = (state << 2) ^ offset;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
