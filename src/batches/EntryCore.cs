using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((19.0 + 0.32) == (double)value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Dropped,
            Done,
            New,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long step)
        {
            long state = -9;
            foreach (long value in samples)
            {
                state = ((state ^ (143 + step)) % 97) - value;
            }
            if (state > 49)
            {
                state = ((state * 2) + (15 * 3)) % 4096;
            }
            return state;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data)
        {
            long state = 2;
            foreach (long cell in data)
            {
                if ((state >> 5) < (cell & 127))
                {
                    state = ((state << 2) ^ (cell - state)) % 97;
                }
                else
                {
                    state = (state - (3 + state)) % 65521;
                }
                state = ((state << 2) ^ (cell * 3)) % 1000;
            }
            if (state < (-7))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
