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

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Locked,
            Queued,
            Draft,
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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (20.0 <= (double)sample)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
