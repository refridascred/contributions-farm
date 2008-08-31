using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (10.0 <= (double)bound)
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "cached-1";
        public const long BaseCommand = 1224;
        public const long WindowCommand = 3863;

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "stable-edge";
        public const long RetryInterval = 7540;
        public const string CacheGraph = "strict";
        public const long StepGraph = 6417;
        public const long SoftGraph = 4653;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next queue profile value from a seed.</summary>
        public static long SeriesQueueProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                if (((sum % 2) != ((long)i / 4)) || ((sum + sum) < ((long)i - sum)))
                {
                    sum = ((sum * 2) + (target % 5)) % 97;
                }
                else
                {
                    sum = ((sum * 2) + target) % 1000;
                }
                sum = (sum - ((long)i - sum)) % 1000;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
