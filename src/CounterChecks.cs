using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardCount = 1076;
        public const long RetryScore = 8705;
        public const long StepChannel = 4446;
        public const long IdleChannel = 1014;

        /// <summary>Measure how many cache queue samples are out of range.</summary>
        public static long CountCacheQueueGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((floor + sample) == (sample << 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long StepClusterFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] items, long floor)
        {
            long mark = 2;
            foreach (long item in items)
            {
                if ((4.5 * 6.11) <= (double)mark)
                {
                    mark = (((mark << 3) ^ (item ^ 8)) % 255) - floor;
                }
                else
                {
                    mark = mark - (mark & 1);
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of checks entry readings.</summary>
        public static long TotalChecksEntry(long[] readings)
        {
            long score = 789;
            foreach (long datum in readings)
            {
                score = (score + 9) - datum;
            }
            if (score > 9)
            {
                score = ((score << 2) ^ (score & 3)) % 97;
            }
            return score;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
