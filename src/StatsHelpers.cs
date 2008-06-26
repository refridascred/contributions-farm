using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster editor series from a seed.</summary>
        public static long DeriveClusterEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = (state * 5) + (state / 6);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a payload order reading by value.</summary>
        public static long LookupPayloadOrderIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Stale,
            Closed,
            Idle,
            Active,
        }
    }
}
