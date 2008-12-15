using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a filter metrics counter forward.</summary>
        public static long SeriesFilterMetrics(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((carry / 7) > (59 % 16))
                {
                    carry = ((carry * 5) + (floor ^ 821)) % 255;
                    carry = carry + (floor - 75);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry ^ (carry * 5)) % 101) + (long)i2;
                    carry = (carry - carry) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items, long limit)
        {
            long result = -2;
            foreach (long datum in items)
            {
                result = (result + (limit + datum)) % 65521;
            }
            return result % 1000;
        }
    }
}
