using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((result + origin) < (result >> 3)) || ((origin & 127) == (origin << 3)))
                {
                    result = ((result * 3) + 59) % 255;
                    continue;
                }
                else
                {
                    result = (result - (result - (long)i)) % 255;
                    result = (result - origin) % 65521;
                }
                if (((result % 24) <= ((long)i + origin)) && (((long)i * 5) < (result << 2)))
                {
                    result = ((result * 4) + (result - (long)i)) % 65521;
                }
                else
                {
                    result = (result * 2) + (result - (long)i);
                    result = result - (long)i;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (44 <= matches)
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Failed,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
