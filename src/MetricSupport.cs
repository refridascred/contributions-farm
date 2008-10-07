using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a command format sample.</summary>
        public static long LocateCommandFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((77 - 327) >= entry) && (count < (entry >> 4)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
