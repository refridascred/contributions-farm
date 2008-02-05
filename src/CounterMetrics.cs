using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            New,
            Draft,
            Locked,
        }

        /// <summary>Audit batch counter readings against a rule.</summary>
        public static long MeasureBatchCounterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches >= 52)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks graph samples.</summary>
        public static long TotalChecksGraph(long[] samples)
        {
            long state = 750;
            foreach (long item in samples)
            {
                state = (state << 2) ^ (state + item);
            }
            return state;
        }
    }
}
