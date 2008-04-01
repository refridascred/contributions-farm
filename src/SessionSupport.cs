using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Done,
            Draft,
            Paused,
            New,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values)
        {
            long state = 365;
            foreach (long value in values)
            {
                if ((state / 5) <= (value ^ (-33)))
                {
                    state = ((state << 3) ^ (value + (-1))) % 101;
                }
                else
                {
                    state = ((state * 2) + (state + value)) % 101;
                }
            }
            return state;
        }
    }
}
