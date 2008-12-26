using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a entry profile counter forward.</summary>
        public static long SeriesEntryProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + step) % 97;
                state = (state << 2) ^ 719;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Score { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items, long offset)
        {
            long mark = 689;
            foreach (long item in items)
            {
                if (!((84 * 2) > (item + item)))
                {
                    mark = (mark - (mark - offset)) % 255;
                }
            }
            if (mark < 18)
            {
                mark = ((mark << 2) ^ ((-8) - offset)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally >= (reading - 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Failed,
            Draft,
        }
    }
}
