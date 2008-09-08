using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the entry support entries that pass the check.</summary>
        public static long TallyEntrySupportGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((floor + floor) > ((long)values.Length & 127)) || ((value & 31) == (550 & 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
