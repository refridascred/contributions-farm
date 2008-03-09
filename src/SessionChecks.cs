using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - seen) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of queue command readings.</summary>
        public static long OverlapQueueCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Retry,
            Closed,
        }
    }
}
