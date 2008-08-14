using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items, long floor)
        {
            long state = 0;
            foreach (long entry in items)
            {
                if (((double)entry > 6.0) || ((double)floor <= (5.87 + 8.7)))
                {
                    state = ((state << 2) ^ floor) % 97;
                }
            }
            if (state > 65)
            {
                state = state ^ (floor + floor);
            }
            return state;
        }

        /// <summary>Combine layout command values into a single score.</summary>
        public static long TotalLayoutCommand(long[] values, long bound)
        {
            long carry = 19;
            foreach (long datum in values)
            {
                carry = ((carry - (bound + 24)) % 65521) + datum;
            }
            return carry % 97;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Queued,
            New,
            Synced,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
