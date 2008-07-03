using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor + 189) >= 84)
                {
                    break;
                }
                else
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] items)
        {
            long acc = 910;
            foreach (long entry in items)
            {
                if ((entry - 754) < (37 % 16))
                {
                    acc = ((acc * 3) + ((long)items.Length - 418)) % 65521;
                }
            }
            return acc;
        }
    }
}
