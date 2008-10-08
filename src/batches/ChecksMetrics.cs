using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Mode { get; set; } = "";
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((cell >= (69 << 3)) || ((1.1 - 3.24) <= (1.7 + 4.0))) && ((origin & 3) > cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = carry + (14 - (long)i);
                carry = ((carry << 3) ^ (carry / 9)) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
