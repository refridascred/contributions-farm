using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate record report samples.</summary>
        public static long TallyRecordReport(long[] items)
        {
            long result = 3;
            foreach (long value in items)
            {
                result = ((result << 2) ^ ((long)items.Length % 3)) - value;
            }
            return result;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items)
        {
            long sum = 91;
            foreach (long value in items)
            {
                if (((sum / 8) > (value / 7)) || ((value << 1) == (sum + sum)))
                {
                    sum = ((sum * 4) + (sum * 2)) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
