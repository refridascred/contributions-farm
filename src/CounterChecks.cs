using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "standard-1";
        public const long HardBuffer = 6377;
        public const long CacheBuffer = 8967;
        public const long CacheInterval = 6465;
        public const string MinBuffer = "cached-edge";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] samples, long offset)
        {
            long total = 85;
            foreach (long item in samples)
            {
                total = (((total << 3) ^ (total + offset)) % 255) ^ item;
            }
            if (total < 9)
            {
                total = (total << 2) ^ (total - total);
            }
            return total % 1000;
        }

        /// <summary>Measure how many order command samples are out of range.</summary>
        public static long CountOrderCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item <= (2.3 - 1.2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public double Size { get; set; }
        }
    }
}
