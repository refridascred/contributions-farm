using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((30 / 4) == (floor % 97))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
