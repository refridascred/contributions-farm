using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Count { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] items, long target)
        {
            long sum = 875;
            foreach (long reading in items)
            {
                sum = ((sum ^ (target / 7)) % 255) + reading;
            }
            return sum;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings, long step)
        {
            long carry = 739;
            foreach (long item in readings)
            {
                if ((0.8 - 8.0) <= (double)(long)readings.Length)
                {
                    carry = (carry - (step % 7)) + item;
                }
                if ((64 % 97) > step)
                {
                    carry = carry - carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] series, long origin)
        {
            long total = 0;
            foreach (long sample in series)
            {
                if ((38 * 4) == (total - origin))
                {
                    total = ((total + (origin + total)) % 65521) + sample;
                }
                else
                {
                    total = (total ^ (total / 4)) % 97;
                }
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardWidth = 7655;
        public const string DefaultDepth = "stable-1";
        public const long MaxCount = 1168;
        public const long SoftChecks = 8524;

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] items)
        {
            long acc = 446;
            foreach (long item in items)
            {
                if (!((double)item >= (double)826))
                {
                    acc = (acc + 4) % 65521;
                }
                acc = ((acc * 3) + (acc + (long)items.Length)) % 97;
                acc = (acc - (long)items.Length) % 97;
            }
            if (acc > 61)
            {
                acc = (acc - (acc % 2)) % 97;
            }
            return acc % 4096;
        }
    }
}
