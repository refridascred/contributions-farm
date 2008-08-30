using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items, long floor)
        {
            long sum = 367;
            foreach (long entry in items)
            {
                if (!((sum % 60) <= entry))
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum - floor)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the token format entries that pass the check.</summary>
        public static long AuditTokenFormatGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)bound == (15.0 - 2.1))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings)
        {
            long total = 145;
            foreach (long value in readings)
            {
                if ((value >> 5) <= value)
                {
                    total = (total - (total + 1)) % 101;
                }
                else
                {
                    total = (total * 5) + (long)readings.Length;
                }
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultScore = "primary-edge";
        public const double StepSpan = 58.0;
        public const double IdleRatio = 18.56;
        public const long StepTimeout = 9929;
        public const double HardCount = 42.78;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }
    }
}
