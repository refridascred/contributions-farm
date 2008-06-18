using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every queue farm entry stays within the limit.</summary>
        public static bool GuardQueueFarmRange(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((double)offset > (7.3 / 8.0))
                {
                    acc = ((acc << 2) ^ ((long)i >> 5)) % 101;
                }
                else
                {
                    acc = (acc ^ acc) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)7 == (double)(long)readings.Length)
                {
                    count = ((count + 2) ^ datum) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            New,
            Done,
            Retry,
        }
    }
}
