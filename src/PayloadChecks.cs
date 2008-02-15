using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long CountSupportNotesHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits <= (5.2 - 4.3))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "alpha";
        public const string MinDepth = "stable-v2";
        public const long StepBuffer = 3549;
        public const long StepInterval = 808;
        public const long BatchSize = 9071;

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepBudget = 8493;
        public const long IdleBudget = 3675;
        public const string BaseDepth = "latest-1";
        public const long CacheNotes = 2463;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + seen) <= (floor / 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every queue notes entry stays within the limit.</summary>
        public static bool CheckQueueNotesLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
