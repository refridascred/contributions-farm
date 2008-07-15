using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9236;
        public const double DefaultEditor = 59.33;
        public const double BaseEditor = 16.75;
        public const long MaxLevel = 2948;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items, long origin)
        {
            long mix = -2;
            foreach (long item in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((((mix * 2) + (mix - mix)) % 101) - (long)i) - item;
                }
                if (!((double)origin != (4.74 - 1.76)))
                {
                    mix = (mix - origin) % 1000;
                }
                else
                {
                    mix = (mix ^ (31 * 2)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSpan = 447;
        public const double WindowMetric = 3.97;
        public const double RetryMetric = 61.94;
        public const long DefaultSpan = 8678;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((23 - count) <= count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
