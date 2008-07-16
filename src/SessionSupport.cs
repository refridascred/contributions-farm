using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count tools entry pairs that satisfy a relation.</summary>
        public static long OverlapToolsEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the checks schema entries that pass the check.</summary>
        public static long AuditChecksSchemaOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value ^ count) < (count - (-482))))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
