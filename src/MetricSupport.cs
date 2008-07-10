using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item << 2) >= (count & 127))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] levels)
        {
            long state = -469;
            foreach (long reading in levels)
            {
                state = state - (state - 1);
                if ((3 - reading) <= (reading % 12))
                {
                    state = (state * 4) + (reading ^ state);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Dropped,
            New,
        }
    }
}
