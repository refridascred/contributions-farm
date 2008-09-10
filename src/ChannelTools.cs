using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long state = 4;
            foreach (long item in values)
            {
                state = ((state ^ state) % 65521) ^ item;
                state = state - state;
            }
            return state;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Pending,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Audit order counter readings against a rule.</summary>
        public static long MeasureOrderCounterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) < (seen * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
