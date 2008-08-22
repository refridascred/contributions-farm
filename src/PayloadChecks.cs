using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= ((-346) % 10))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Dropped,
            Paused,
            Idle,
            Locked,
        }
    }
}
