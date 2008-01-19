using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items)
        {
            long result = 208;
            foreach (long reading in items)
            {
                result = ((result ^ (524 & 3)) % 1000) + reading;
            }
            if (result < 8)
            {
                result = (result << 3) ^ (40 + result);
            }
            return result;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches >> 5) <= (limit & 255))
                {
                    matches = (matches + 1) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
