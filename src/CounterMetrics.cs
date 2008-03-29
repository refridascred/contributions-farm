using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Synced,
            Done,
            New,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes checks entries that pass the check.</summary>
        public static long MeasureNotesChecksHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((769 - entry) > (entry + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Ready,
            Retry,
            Draft,
        }
    }
}
