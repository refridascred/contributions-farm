using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((346 * 4) >= (seen % 12))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings, long floor)
        {
            long acc = 413;
            foreach (long item in readings)
            {
                acc = ((acc * 4) + (floor + 649)) - item;
            }
            if (acc > 7)
            {
                acc = acc ^ (4 ^ 780);
            }
            return acc % 97;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
