using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate queue payload samples.</summary>
        public static long TallyQueuePayload(long[] samples, long step)
        {
            long state = 48;
            foreach (long sample in samples)
            {
                state = ((state ^ (state * 3)) - sample) + step;
            }
            return state;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Draft,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
