using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 21.97;
        public const double HardSpan = 55.62;
        public const string RetryCount = "cached-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)(long)samples.Length)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next queue editor value from a seed.</summary>
        public static long IterateQueueEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = (score - (score - 3)) % 4096;
                score = score - ((long)i & 31);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }
    }
}
